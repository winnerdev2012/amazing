//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test1Entity {

    public MultipleContextStandardEventComponent multipleContextStandardEvent { get { return (MultipleContextStandardEventComponent)GetComponent(Test1ComponentsLookup.MultipleContextStandardEvent); } }
    public bool hasMultipleContextStandardEvent { get { return HasComponent(Test1ComponentsLookup.MultipleContextStandardEvent); } }

    public void AddMultipleContextStandardEvent(string newValue) {
        var index = Test1ComponentsLookup.MultipleContextStandardEvent;
        var component = (MultipleContextStandardEventComponent)CreateComponent(index, typeof(MultipleContextStandardEventComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMultipleContextStandardEvent(string newValue) {
        var index = Test1ComponentsLookup.MultipleContextStandardEvent;
        var component = (MultipleContextStandardEventComponent)CreateComponent(index, typeof(MultipleContextStandardEventComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMultipleContextStandardEvent() {
        RemoveComponent(Test1ComponentsLookup.MultipleContextStandardEvent);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test1Entity : IMultipleContextStandardEventEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test1Matcher {

    static Entitas.IMatcher<Test1Entity> _matcherMultipleContextStandardEvent;

    public static Entitas.IMatcher<Test1Entity> MultipleContextStandardEvent {
        get {
            if (_matcherMultipleContextStandardEvent == null) {
                var matcher = (Entitas.Matcher<Test1Entity>)Entitas.Matcher<Test1Entity>.AllOf(Test1ComponentsLookup.MultipleContextStandardEvent);
                matcher.componentNames = Test1ComponentsLookup.componentNames;
                _matcherMultipleContextStandardEvent = matcher;
            }

            return _matcherMultipleContextStandardEvent;
        }
    }
}
