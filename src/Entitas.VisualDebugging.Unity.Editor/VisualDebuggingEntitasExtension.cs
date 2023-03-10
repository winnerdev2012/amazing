namespace Entitas.VisualDebugging.Unity.Editor
{
    public static class VisualDebuggingEntitasExtension
    {
        public static IEntity CreateEntity(this IContext context) =>
            (IEntity)context.GetType().GetMethod("CreateEntity").Invoke(context, null);
    }
}
