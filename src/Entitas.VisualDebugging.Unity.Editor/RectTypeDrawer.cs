using System;
using UnityEditor;
using UnityEngine;

namespace Entitas.VisualDebugging.Unity.Editor
{
    public class RectTypeDrawer : ITypeDrawer
    {
        public bool HandlesType(Type type) => type == typeof(Rect);

        public object DrawAndGetNewValue(Type memberType, string memberName, object value, object target) => 
            EditorGUILayout.RectField(memberName, (Rect)value);
    }
}
