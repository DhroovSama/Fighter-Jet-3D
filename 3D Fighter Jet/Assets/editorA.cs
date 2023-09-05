using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(recursion))]
public class editorA : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        recursion rec = (recursion)target;
        if (GUILayout.Button("Check"))
        {
            
        }
    }
}
