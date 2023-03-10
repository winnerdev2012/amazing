using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Entitas.VisualDebugging.Unity
{
    public enum AvgResetInterval
    {
        Always = 1,
        VeryFast = 30,
        Fast = 60,
        Normal = 120,
        Slow = 300,
        Never = int.MaxValue
    }

    public class DebugSystems : Systems
    {
        public static AvgResetInterval avgResetInterval = AvgResetInterval.Never;

        public int totalInitializeSystemsCount
        {
            get
            {
                var total = 0;
                foreach (var system in _initializeSystems)
                    total += system is DebugSystems debugSystems ? debugSystems.totalInitializeSystemsCount : 1;

                return total;
            }
        }

        public int totalExecuteSystemsCount
        {
            get
            {
                var total = 0;
                foreach (var system in _executeSystems)
                    total += system is DebugSystems debugSystems ? debugSystems.totalExecuteSystemsCount : 1;

                return total;
            }
        }

        public int totalCleanupSystemsCount
        {
            get
            {
                var total = 0;
                foreach (var system in _cleanupSystems)
                    total += system is DebugSystems debugSystems ? debugSystems.totalCleanupSystemsCount : 1;

                return total;
            }
        }

        public int totalTearDownSystemsCount
        {
            get
            {
                var total = 0;
                foreach (var system in _tearDownSystems)
                    total += system is DebugSystems debugSystems ? debugSystems.totalTearDownSystemsCount : 1;

                return total;
            }
        }

        public int totalSystemsCount
        {
            get
            {
                var total = 0;
                foreach (var system in _systems)
                    total += system is DebugSystems debugSystems ? debugSystems.totalSystemsCount : 1;

                return total;
            }
        }

        public int initializeSystemsCount => _initializeSystems.Count;
        public int executeSystemsCount => _executeSystems.Count;
        public int cleanupSystemsCount => _cleanupSystems.Count;
        public int tearDownSystemsCount => _tearDownSystems.Count;

        public string name => _name;
        public GameObject gameObject => _gameObject;
        public SystemInfo systemInfo => _systemInfo;
        public double executeDuration => _executeDuration;
        public double cleanupDuration => _cleanupDuration;

        public SystemInfo[] initializeSystemInfos => _initializeSystemInfos.ToArray();
        public SystemInfo[] executeSystemInfos => _executeSystemInfos.ToArray();
        public SystemInfo[] cleanupSystemInfos => _cleanupSystemInfos.ToArray();
        public SystemInfo[] tearDownSystemInfos => _tearDownSystemInfos.ToArray();

        public bool paused;

        string _name;

        List<ISystem> _systems;
        GameObject _gameObject;
        SystemInfo _systemInfo;

        List<SystemInfo> _initializeSystemInfos;
        List<SystemInfo> _executeSystemInfos;
        List<SystemInfo> _cleanupSystemInfos;
        List<SystemInfo> _tearDownSystemInfos;

        Stopwatch _stopwatch;

        double _executeDuration;
        double _cleanupDuration;

        public DebugSystems(string name)
        {
            initialize(name);
        }

        protected DebugSystems(bool noInit) { }

        protected void initialize(string name)
        {
            _name = name;
            _gameObject = new GameObject(name);
            _gameObject.AddComponent<DebugSystemsBehaviour>().Init(this);

            _systemInfo = new SystemInfo(this);

            _systems = new List<ISystem>();
            _initializeSystemInfos = new List<SystemInfo>();
            _executeSystemInfos = new List<SystemInfo>();
            _cleanupSystemInfos = new List<SystemInfo>();
            _tearDownSystemInfos = new List<SystemInfo>();

            _stopwatch = new Stopwatch();
        }

        public override Systems Add(ISystem system)
        {
            _systems.Add(system);

            SystemInfo childSystemInfo;

            if (system is DebugSystems debugSystems)
            {
                childSystemInfo = debugSystems.systemInfo;
                debugSystems.gameObject.transform.SetParent(_gameObject.transform, false);
            }
            else
            {
                childSystemInfo = new SystemInfo(system);
            }

            childSystemInfo.parentSystemInfo = _systemInfo;

            if (childSystemInfo.isInitializeSystems) _initializeSystemInfos.Add(childSystemInfo);
            if (childSystemInfo.isExecuteSystems || childSystemInfo.isReactiveSystems) _executeSystemInfos.Add(childSystemInfo);
            if (childSystemInfo.isCleanupSystems) _cleanupSystemInfos.Add(childSystemInfo);
            if (childSystemInfo.isTearDownSystems) _tearDownSystemInfos.Add(childSystemInfo);

            return base.Add(system);
        }

        public void ResetDurations()
        {
            foreach (var systemInfo in _executeSystemInfos)
                systemInfo.ResetDurations();

            foreach (var system in _systems)
                if (system is DebugSystems debugSystems)
                    debugSystems.ResetDurations();
        }

        public override void Initialize()
        {
            for (var i = 0; i < _initializeSystems.Count; i++)
            {
                var systemInfo = _initializeSystemInfos[i];
                if (systemInfo.isActive)
                {
                    _stopwatch.Reset();
                    _stopwatch.Start();
                    _initializeSystems[i].Initialize();
                    _stopwatch.Stop();
                    systemInfo.initializationDuration = _stopwatch.Elapsed.TotalMilliseconds;
                }
            }
        }

        public override void Execute()
        {
            if (!paused)
                StepExecute();
        }

        public override void Cleanup()
        {
            if (!paused)
                StepCleanup();
        }

        public void StepExecute()
        {
            _executeDuration = 0;
            if (Time.frameCount % (int)avgResetInterval == 0)
                ResetDurations();

            for (var i = 0; i < _executeSystems.Count; i++)
            {
                var systemInfo = _executeSystemInfos[i];
                if (systemInfo.isActive)
                {
                    _stopwatch.Reset();
                    _stopwatch.Start();
                    _executeSystems[i].Execute();
                    _stopwatch.Stop();
                    var duration = _stopwatch.Elapsed.TotalMilliseconds;
                    _executeDuration += duration;
                    systemInfo.AddExecutionDuration(duration);
                }
            }
        }

        public void StepCleanup()
        {
            _cleanupDuration = 0;
            for (var i = 0; i < _cleanupSystems.Count; i++)
            {
                var systemInfo = _cleanupSystemInfos[i];
                if (systemInfo.isActive)
                {
                    _stopwatch.Reset();
                    _stopwatch.Start();
                    _cleanupSystems[i].Cleanup();
                    _stopwatch.Stop();
                    var duration = _stopwatch.Elapsed.TotalMilliseconds;
                    _cleanupDuration += duration;
                    systemInfo.AddCleanupDuration(duration);
                }
            }
        }

        public override void TearDown()
        {
            for (var i = 0; i < _tearDownSystems.Count; i++)
            {
                var systemInfo = _tearDownSystemInfos[i];
                if (systemInfo.isActive)
                {
                    _stopwatch.Reset();
                    _stopwatch.Start();
                    _tearDownSystems[i].TearDown();
                    _stopwatch.Stop();
                    systemInfo.teardownDuration = _stopwatch.Elapsed.TotalMilliseconds;
                }
            }
        }
    }
}
