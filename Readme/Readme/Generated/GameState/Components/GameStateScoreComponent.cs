//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity scoreEntity { get { return GetGroup(GameStateMatcher.Score).GetSingleEntity(); } }
    public ScoreComponent score { get { return scoreEntity.score; } }
    public bool hasScore { get { return scoreEntity != null; } }

    public GameStateEntity SetScore(int newValue) {
        if (hasScore) {
            throw new Entitas.EntitasException("Could not set Score!\n" + this + " already has an entity with ScoreComponent!",
                "You should check if the context already has a scoreEntity before setting it or use context.ReplaceScore().");
        }
        var entity = CreateEntity();
        entity.AddScore(newValue);
        return entity;
    }

    public void ReplaceScore(int newValue) {
        var entity = scoreEntity;
        if (entity == null) {
            entity = SetScore(newValue);
        } else {
            entity.ReplaceScore(newValue);
        }
    }

    public void RemoveScore() {
        scoreEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public ScoreComponent score { get { return (ScoreComponent)GetComponent(GameStateComponentsLookup.Score); } }
    public bool hasScore { get { return HasComponent(GameStateComponentsLookup.Score); } }

    public void AddScore(int newValue) {
        var index = GameStateComponentsLookup.Score;
        var component = (ScoreComponent)CreateComponent(index, typeof(ScoreComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceScore(int newValue) {
        var index = GameStateComponentsLookup.Score;
        var component = (ScoreComponent)CreateComponent(index, typeof(ScoreComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveScore() {
        RemoveComponent(GameStateComponentsLookup.Score);
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
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherScore;

    public static Entitas.IMatcher<GameStateEntity> Score {
        get {
            if (_matcherScore == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.Score);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherScore = matcher;
            }

            return _matcherScore;
        }
    }
}
