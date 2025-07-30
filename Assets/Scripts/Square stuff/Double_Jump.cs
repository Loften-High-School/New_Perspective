using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Double_Jump : MonoBehaviour
{
    public int jumpCount = 0;
    public bool isGrounded = false;
    public float jumpForce;
    public int maxJumps = 2;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }
    
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space)) | (Input.GetKeyDown(KeyCode.W)) | (Input.GetKeyDown(KeyCode.UpArrow)) && ((isGrounded == false) && (jumpCount < maxJumps)))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
        jumpCount++;
    }

    void OnCollisionEnter2D (Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }

    void OnCollisionExit2D (Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
