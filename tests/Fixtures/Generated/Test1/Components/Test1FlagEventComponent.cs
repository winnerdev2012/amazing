//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test1Entity {

    static readonly FlagEventComponent flagEventComponent = new FlagEventComponent();

    public bool isFlagEvent {
        get { return HasComponent(Test1ComponentsLookup.FlagEvent); }
        set {
            if (value != isFlagEvent) {
                var index = Test1ComponentsLookup.FlagEvent;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : flagEventComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test1Matcher {

    static Entitas.IMatcher<Test1Entity> _matcherFlagEvent;

    public static Entitas.IMatcher<Test1Entity> FlagEvent {
        get {
            if (_matcherFlagEvent == null) {
                var matcher = (Entitas.Matcher<Test1Entity>)Entitas.Matcher<Test1Entity>.AllOf(Test1ComponentsLookup.FlagEvent);
                matcher.componentNames = Test1ComponentsLookup.componentNames;
                _matcherFlagEvent = matcher;
            }

            return _matcherFlagEvent;
        }
    }
}
