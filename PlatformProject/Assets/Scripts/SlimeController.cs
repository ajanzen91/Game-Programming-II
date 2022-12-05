using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    Quaternion rotation;
    Rigidbody rigidbody;
    const float Gravity = -9.81f;
    private bool isGrounded;
    public float moveSpeed;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
        rigidbody = GetComponent<Rigidbody>();
        rotation = Random.rotation;
        rotation.x = rotation.z = 0f;
        rotation.w = 1f;
        transform.rotation = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            if(velocity.y <= 0f)
            {
                velocity.y = 0f;
            }
        }
    }
}
