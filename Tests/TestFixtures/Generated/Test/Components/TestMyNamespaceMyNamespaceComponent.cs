//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public My.Namespace.MyNamespaceComponent myNamespaceMyNamespace { get { return (My.Namespace.MyNamespaceComponent)GetComponent(TestComponentsLookup.MyNamespaceMyNamespace); } }
    public bool hasMyNamespaceMyNamespace { get { return HasComponent(TestComponentsLookup.MyNamespaceMyNamespace); } }

    public void AddMyNamespaceMyNamespace(string newValue) {
        var index = TestComponentsLookup.MyNamespaceMyNamespace;
        var component = (My.Namespace.MyNamespaceComponent)CreateComponent(index, typeof(My.Namespace.MyNamespaceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMyNamespaceMyNamespace(string newValue) {
        var index = TestComponentsLookup.MyNamespaceMyNamespace;
        var component = (My.Namespace.MyNamespaceComponent)CreateComponent(index, typeof(My.Namespace.MyNamespaceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMyNamespaceMyNamespace() {
        RemoveComponent(TestComponentsLookup.MyNamespaceMyNamespace);
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
public partial class TestEntity : IMyNamespaceMyNamespaceEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherMyNamespaceMyNamespace;

    public static Entitas.IMatcher<TestEntity> MyNamespaceMyNamespace {
        get {
            if (_matcherMyNamespaceMyNamespace == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.MyNamespaceMyNamespace);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherMyNamespaceMyNamespace = matcher;
            }

            return _matcherMyNamespaceMyNamespace;
        }
    }
}
