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
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
        Rigidbody body = GetComponent<Rigidbody>();
        body.AddTorque(new Vector3(xSpeed, 0, ySpeed) * ballSpeed * Time.deltaTime);
        Debug.Log(body.transform.position.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jump = new Vector3(0.0f, 500.0f, 0.0f);
            Debug.Log(body.transform.position.y);
            body.AddForce(jump);
          }
    }
    /*
    private bool IsGrounded()
    {
        Vector3 sphereBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
        bool grounded = Physics.CheckSphere(sphereBottom, distanceToGround, groundLayer, QueryTriggerInteraction.Ignore);
        Debug.Log(grounded);
        Debug.Log(sphereBottom);
        return grounded;
    }*/

}
