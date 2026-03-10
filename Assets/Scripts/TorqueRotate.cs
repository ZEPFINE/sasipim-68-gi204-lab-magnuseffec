using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    public float TorqueSpeed;

    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.bKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, 0, TorqueSpeed);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
