using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Double_Jump : MonoBehaviour
{
    public int jumpcount = 0;
    public bool IsGrounded = false;
    public float Jumpforce = 5f;
    public int maxjumps = 2;
    private Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            
        }
    }
}
