using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float ballSpeed;
    public float jumpVelocity = 5f;
    public LayerMask groundLayer;
    public float distanceToGround = 0.1f;


    private Rigidbody _rb;
    private SphereCollider _col;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rb.AddTorque(Vector3.forward * ballSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rb.AddTorque(Vector3.back * ballSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rb.AddTorque(Vector3.right * ballSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.AddTorque(Vector3.left * ballSpeed);
        }

        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            Vector3 jump = new Vector3(0.0f, 500.0f, 0.0f);
            _rb.AddForce(jump);
        }
    }

private bool IsGrounded()
{
    Vector3 sphereBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
    bool grounded = Physics.CheckSphere(sphereBottom, distanceToGround, groundLayer, QueryTriggerInteraction.Ignore);
    return grounded;

    }
}