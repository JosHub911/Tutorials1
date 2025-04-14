using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = 500f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = rb.transform.forward * speed * Time.fixedDeltaTime;
    }
}