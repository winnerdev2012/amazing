//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class StandardAddedAndRemovedEventEventSystem : Entitas.ReactiveSystem<TestEntity> {

    readonly Entitas.IGroup<TestEntity> _listeners;

    public StandardAddedAndRemovedEventEventSystem(Contexts contexts) : base(contexts.test) {
        _listeners = contexts.test.GetGroup(TestMatcher.StandardAddedAndRemovedEventListener);
    }

    protected override Entitas.ICollector<TestEntity> GetTrigger(Entitas.IContext<TestEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.AddedOrRemoved(TestMatcher.StandardAddedAndRemovedEvent)
        );
    }

    protected override bool Filter(TestEntity entity) {
        return true;
    }

    protected override void Execute(System.Collections.Generic.List<TestEntity> entities) {
        foreach (var e in entities) {
            var component = e.standardAddedAndRemovedEvent;
            foreach (var listener in _listeners) {
                listener.standardAddedAndRemovedEventListener.value.OnStandardAddedAndRemovedEventAddedOrRemoved(e, component.value);
            }
        }
    }
}
