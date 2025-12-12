using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed = 6f;
    public float jumpForce = 5f;
    public Rigidbody rb;
    public LayerMask groundMask;
    bool jumpPressed = false;


    bool IsGrounded()
    {
        CapsuleCollider col = GetComponent<CapsuleCollider>();

        float length = (col.height * 0.5f) - col.radius + 0.1f;

        return Physics.Raycast(transform.position, Vector3.down, length, groundMask);
    }

    void Start()
    {
        rb.freezeRotation = true;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            jumpPressed = true;
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 dir = (transform.right * x + transform.forward * z).normalized;
        Vector3 move = dir * speed;

        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
        
        // Jump
        if (jumpPressed && IsGrounded())
        {
            Debug.Log("Jump");
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
        
        jumpPressed = false;
    }
}
