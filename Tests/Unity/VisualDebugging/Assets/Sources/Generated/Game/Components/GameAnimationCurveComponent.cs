//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnimationCurveComponent animationCurve { get { return (AnimationCurveComponent)GetComponent(GameComponentsLookup.AnimationCurve); } }
    public bool hasAnimationCurve { get { return HasComponent(GameComponentsLookup.AnimationCurve); } }

    public void AddAnimationCurve(UnityEngine.AnimationCurve newAnimationCurve) {
        var index = GameComponentsLookup.AnimationCurve;
        var component = (AnimationCurveComponent)CreateComponent(index, typeof(AnimationCurveComponent));
        component.animationCurve = newAnimationCurve;
        AddComponent(index, component);
    }

    public void ReplaceAnimationCurve(UnityEngine.AnimationCurve newAnimationCurve) {
        var index = GameComponentsLookup.AnimationCurve;
        var component = (AnimationCurveComponent)CreateComponent(index, typeof(AnimationCurveComponent));
        component.animationCurve = newAnimationCurve;
        ReplaceComponent(index, component);
    }

    public void RemoveAnimationCurve() {
        RemoveComponent(GameComponentsLookup.AnimationCurve);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnimationCurve;

    public static Entitas.IMatcher<GameEntity> AnimationCurve {
        get {
            if (_matcherAnimationCurve == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnimationCurve);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnimationCurve = matcher;
            }

            return _matcherAnimationCurve;
        }
    }
}
