using System.Collections.Generic;
using UnityEngine;

public class Segmentor : MonoBehaviour
{
    [Min(3)]
    public int SegmentCount = 3;
    public float FieldScale = 1;

    private List<GameObject> m_boxes = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateShape();
    }
    public void GenerateShape()
    {
        //remove old boxes
        foreach(var box in m_boxes)
        {
            DestroyImmediate(box);
        }
        m_boxes = new List<GameObject>();

        //find the angle of stuff
        float angle = 2 * Mathf.PI / SegmentCount;
        //find the size of edge collider
        float size = 10.1f * Mathf.Pow(SegmentCount, -1.17f);

        for(int i = 0; i < SegmentCount; i++)
        {
            GameObject box = new GameObject();
            box.transform.SetParent(transform);
            BoxCollider2D box2D = box.AddComponent<BoxCollider2D>();
            box2D.size = new Vector2(0.01f, size);
            box2D.transform.SetLocalPositionAndRotation(new Vector3(Mathf.Cos(angle * i), Mathf.Sin(angle * i)) * FieldScale, Quaternion.Euler(0,0,angle * Mathf.Rad2Deg * i));
            box2D.isTrigger = true;
            FieldSegment segment = box.AddComponent<FieldSegment>();
            segment.SetHitEvent(i, ApplyFieldEffect);
            m_boxes.Add(box);
        }
    }
    public void ApplyFieldEffect(int index, GameObject target)
    {
        //clamp the index to the number of segments
        //apply the effect to the object
    }
}
