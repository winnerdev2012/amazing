//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public My.Namespace.MultipleEntityIndicesComponent myNamespaceMultipleEntityIndices { get { return (My.Namespace.MultipleEntityIndicesComponent)GetComponent(TestComponentsLookup.MyNamespaceMultipleEntityIndices); } }
    public bool hasMyNamespaceMultipleEntityIndices { get { return HasComponent(TestComponentsLookup.MyNamespaceMultipleEntityIndices); } }

    public void AddMyNamespaceMultipleEntityIndices(string newValue, string newValue2) {
        var index = TestComponentsLookup.MyNamespaceMultipleEntityIndices;
        var component = CreateComponent<My.Namespace.MultipleEntityIndicesComponent>(index);
        component.value = newValue;
        component.value2 = newValue2;
        AddComponent(index, component);
    }

    public void ReplaceMyNamespaceMultipleEntityIndices(string newValue, string newValue2) {
        var index = TestComponentsLookup.MyNamespaceMultipleEntityIndices;
        var component = CreateComponent<My.Namespace.MultipleEntityIndicesComponent>(index);
        component.value = newValue;
        component.value2 = newValue2;
        ReplaceComponent(index, component);
    }

    public void RemoveMyNamespaceMultipleEntityIndices() {
        RemoveComponent(TestComponentsLookup.MyNamespaceMultipleEntityIndices);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity : IMyNamespaceMultipleEntityIndicesEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherMyNamespaceMultipleEntityIndices;

    public static Entitas.IMatcher<TestEntity> MyNamespaceMultipleEntityIndices {
        get {
            if (_matcherMyNamespaceMultipleEntityIndices == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.MyNamespaceMultipleEntityIndices);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherMyNamespaceMultipleEntityIndices = matcher;
            }

            return _matcherMyNamespaceMultipleEntityIndices;
        }
    }
}
