using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Movement : MonoBehaviour

{
    public Circle_Movement circle_movement;
    public GameOver gameOver;
    public float maxSpeed;
    public float force;
    public Circle_Difficulty circle_difficulty;
    public AudioSource Jump_sound;
    public Sound_Button Sound;
  //Jumpforce variable
  [SerializeField] int jumpforce;

    //a true or false variable that checks the ground
    [SerializeField] bool isGrounded = false;

    [SerializeField] float horizontalMove;
    
    
    private Rigidbody2D rb;

    public Circle_Pause pause;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Jump_sound.enabled = false;
    }

    
    // Update is called once per frame
    void Update()
    {
        if(pause.paused == true)
        {
          circle_movement.enabled = false;
        }
        else if(pause.paused == false)
        {
          circle_movement.enabled = true;
        }
        
        if(Sound.ON == -1)
        {
          Jump_sound.enabled = false;
        }
        
        horizontalMove = Input.GetAxisRaw("walk");
        
      

    if(circle_difficulty.easy == true|circle_difficulty.medium == true|circle_difficulty.hard == true|circle_difficulty.insane == true)
    {
      if (gameOver.isAlive == true)
     { 
      if ((Input.GetKeyDown(KeyCode.D))|(Input.GetKey(KeyCode.D)))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
            rb.AddForce(Vector3.right * force * 15);
            Debug.Log("Key D has been pressed");
        }
      if ((Input.GetKeyDown(KeyCode.A))|(Input.GetKey(KeyCode.A)))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
            rb.AddForce(Vector3.left * force * 15);
            Debug.Log("Key A has been pressed");
        }
      if (Input.GetKeyDown(KeyCode.Space))     
        {
            if (isGrounded != false)
            {
              if(Sound.ON == 1)
              {
                Jump_sound.enabled = true;
              }
              isGrounded = false;
              rb.AddForce(Vector3.up * 5 * jumpforce);
              Debug.Log("Key Space has been pressed");
            }
        }
      if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded != false)
            {
              if(Sound.ON == 1)
              {
                Jump_sound.enabled = true;
              }
              isGrounded = false;
              Jump_sound.enabled = true;
              rb.AddForce(Vector3.up * 5 * jumpforce);
              Debug.Log("Key W has been pressed");
            }
        }
      if (Input.GetKeyDown(KeyCode.UpArrow))     
        {
            if (isGrounded != false)
            {
              if(Sound.ON == 1)
              {
                Jump_sound.enabled = true;
              }
              isGrounded = false;
              Jump_sound.enabled = true;
              rb.AddForce(Vector3.up * 5 * jumpforce);
              Debug.Log("Key Up Arrow has been pressed");
            }
        }  
      if ((Input.GetKeyDown(KeyCode.RightArrow))|(Input.GetKey(KeyCode.RightArrow))) 
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
            rb.AddForce(Vector3.right * force * 15);
            Debug.Log("Right Arrow Key has been pressed");
        }
      if ((Input.GetKeyDown(KeyCode.LeftArrow))|(Input.GetKey(KeyCode.LeftArrow)))    
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
            rb.AddForce(Vector3.left * force * 15);
            Debug.Log("Key Left Arrow has been pressed");
        }
     }
    }
  }
      //Checks if player colides with ground
      private void OnCollisionEnter2D(Collision2D collider)
      {
        if (isGrounded == false)
          {
            Jump_sound.enabled = false;
            if (collider.gameObject.CompareTag("Ground"))
              {
                isGrounded = true;
                Debug.Log("Ground is detected");
              }
        
          }
            if(collider.gameObject.CompareTag("DeathLine"))
          {
            Debug.Log("WOMP WOMP");
            Destroy(gameObject);
            gameOver.isAlive = false;
          }
        
      }
}