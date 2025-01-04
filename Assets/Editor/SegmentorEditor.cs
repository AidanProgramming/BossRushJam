using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Segmentor))]
public class SegmentorEditor : Editor
{ 
    Segmentor m_target;
    private void OnEnable()
    {
        m_target = (Segmentor)target;
    }
    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("Generate Shape"))
        {
            m_target.GenerateShape();
        }
        base.OnInspectorGUI();
    }
}
