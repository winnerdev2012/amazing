//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test1Entity {

    public Test2ContextComponent test2Context { get { return (Test2ContextComponent)GetComponent(Test1ComponentsLookup.Test2Context); } }
    public bool hasTest2Context { get { return HasComponent(Test1ComponentsLookup.Test2Context); } }

    public void AddTest2Context(string newValue) {
        var index = Test1ComponentsLookup.Test2Context;
        var component = (Test2ContextComponent)CreateComponent(index, typeof(Test2ContextComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTest2Context(string newValue) {
        var index = Test1ComponentsLookup.Test2Context;
        var component = (Test2ContextComponent)CreateComponent(index, typeof(Test2ContextComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTest2Context() {
        RemoveComponent(Test1ComponentsLookup.Test2Context);
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
public partial class Test1Entity : ITest2ContextEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test1Matcher {

    static Entitas.IMatcher<Test1Entity> _matcherTest2Context;

    public static Entitas.IMatcher<Test1Entity> Test2Context {
        get {
            if (_matcherTest2Context == null) {
                var matcher = (Entitas.Matcher<Test1Entity>)Entitas.Matcher<Test1Entity>.AllOf(Test1ComponentsLookup.Test2Context);
                matcher.componentNames = Test1ComponentsLookup.componentNames;
                _matcherTest2Context = matcher;
            }

            return _matcherTest2Context;
        }
    }
}
