//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public StructToGenerateComponent structToGenerate { get { return (StructToGenerateComponent)GetComponent(TestComponentsLookup.StructToGenerate); } }
    public bool hasStructToGenerate { get { return HasComponent(TestComponentsLookup.StructToGenerate); } }

    public void AddStructToGenerate(My.Namespace.StructToGenerate newValue) {
        var index = TestComponentsLookup.StructToGenerate;
        var component = CreateComponent<StructToGenerateComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStructToGenerate(My.Namespace.StructToGenerate newValue) {
        var index = TestComponentsLookup.StructToGenerate;
        var component = CreateComponent<StructToGenerateComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStructToGenerate() {
        RemoveComponent(TestComponentsLookup.StructToGenerate);
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
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherStructToGenerate;

    public static Entitas.IMatcher<TestEntity> StructToGenerate {
        get {
            if (_matcherStructToGenerate == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.StructToGenerate);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherStructToGenerate = matcher;
            }

            return _matcherStructToGenerate;
        }
    }
}
