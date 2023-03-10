//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test1Entity {

    public PositionComponent position { get { return (PositionComponent)GetComponent(Test1ComponentsLookup.Position); } }
    public bool hasPosition { get { return HasComponent(Test1ComponentsLookup.Position); } }

    public void AddPosition(int newX, int newY) {
        var index = Test1ComponentsLookup.Position;
        var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
        component.x = newX;
        component.y = newY;
        AddComponent(index, component);
    }

    public void ReplacePosition(int newX, int newY) {
        var index = Test1ComponentsLookup.Position;
        var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
        component.x = newX;
        component.y = newY;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(Test1ComponentsLookup.Position);
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

    static Entitas.IMatcher<Test1Entity> _matcherPosition;

    public static Entitas.IMatcher<Test1Entity> Position {
        get {
            if (_matcherPosition == null) {
                var matcher = (Entitas.Matcher<Test1Entity>)Entitas.Matcher<Test1Entity>.AllOf(Test1ComponentsLookup.Position);
                matcher.componentNames = Test1ComponentsLookup.componentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}
