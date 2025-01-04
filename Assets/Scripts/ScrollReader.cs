using UnityEngine;

public class ScrollReader : MonoBehaviour
{
    public Rigidbody Target;
    public float ScrollDelta;
    public float Spinspeed;
    public float SpinVelocityClamp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScrollDelta = Input.mouseScrollDelta.y;

        Target.AddTorque(new(0,0,ScrollDelta * Spinspeed * Time.deltaTime), ForceMode.VelocityChange);
        Target.maxAngularVelocity = SpinVelocityClamp;

        LineRenderer line = new LineRenderer();
        
        //m_target.RotateAround(m_target.position, new(0,0,1), scrollDelta * spinspeed * Time.deltaTime);
    }
}
