using UnityEngine;
using UnityEngine.UIElements;

public class FieldSegment : MonoBehaviour
{
    public delegate void CallbackEvent(int num, GameObject other);
    private CallbackEvent m_hitEvent;
    private int m_indexValue;
    public void SetHitEvent(int index, CallbackEvent callback)
    {
        m_hitEvent = callback;
        m_indexValue = index;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //if other is bullet
        m_hitEvent.Invoke(m_indexValue, other.gameObject);
    }
}
