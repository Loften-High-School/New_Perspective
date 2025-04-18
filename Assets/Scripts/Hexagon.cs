using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Jump_sound.enabled = false;
    }
    
    // Cooldown time to prevent spamming teleport
    private float lastTeleportTime = -Mathf.Infinity; // Track last teleport time


    void Teleport()
    {
        
    }




    public float teleportCooldown;
    public bool jumped;
    public Movement movement;
    public GameOver gameOver;
    public float maxSpeed;
    public float force;
    public Difficulty difficulty;
    public AudioSource Jump_sound;
    public Sound_Button Sound;
    //Jumpforce variable
    public int jumpforce;

    //a true or false variable that checks the ground
    public bool isGrounded = false;

    public float horizontalMove;
    
    public bool Moving;
    
    public Animator animator;
    
    private Rigidbody2D rb;

    public Pause pause;
    

    
    // Update is called once per frame
    void Update()
    {
        
        if (jumped == true)
        {
            // Ensure the cooldown has passed since the last teleport
            if (Time.time - lastTeleportTime >= teleportCooldown)
            {
                {
                
                Teleport();
                lastTeleportTime = Time.time; // Update last teleport time
                }
            }
        }
        
        
        if(pause.paused == true)
        {
          movement.enabled = false;
        }
        else if(pause.paused == false)
        {
          movement.enabled = true;
        }
        
        if(Sound.ON == -1)
        {
          Jump_sound.enabled = false;
        }
        
        horizontalMove = Input.GetAxisRaw("walk");
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
      if (horizontalMove > 0)
      {
        animator.SetFloat("speed", -1);
      }
      else if (horizontalMove < 0)
      {
        animator.SetFloat("speed", 1);
      }
      if (Moving != true)
      {
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        if (difficulty.insane != true)
        {
          rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
      }
      else if (Moving == true)
      {
        rb.constraints = RigidbodyConstraints2D.None;
        if (difficulty.insane != true)
        {
          rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
      }

    if(difficulty.easy == true|difficulty.medium == true|difficulty.hard == true|difficulty.insane == true)
    {
      if (gameOver.isAlive == true)
     { 
      if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector3(15 * force * horizontalMove, rb.velocity.y, 0);
            rb.AddForce(Vector3.right * force * Time.deltaTime);
            Moving = true;
            Debug.Log("Key D has been pressed");
        }
        if (Input.GetKeyUp(KeyCode.D)|Input.GetKeyUp(KeyCode.A)|Input.GetKeyUp(KeyCode.RightArrow)|Input.GetKeyUp(KeyCode.LeftArrow))
        {
          Moving = false;
        }
      if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(15 * force * horizontalMove, rb.velocity.y, 0);
            rb.AddForce(Vector3.left * force * Time.deltaTime);
            Moving = true;
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
              jumped = true;
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
              jumped = true;
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
              jumped = true;
              Jump_sound.enabled = true;
              rb.AddForce(Vector3.up * 5 * jumpforce);
              Debug.Log("Key Up Arrow has been pressed");
            }
        }  
      if (Input.GetKeyDown(KeyCode.RightArrow))     
        {
            rb.velocity = new Vector3(15 * force * horizontalMove, rb.velocity.y, 0);
            rb.AddForce(Vector3.right * force * Time.deltaTime);
            Moving = true;
            Debug.Log("Right Arrow Key has been pressed");
        }
      if (Input.GetKeyDown(KeyCode.LeftArrow))     
        {
            rb.velocity = new Vector3(15 * force * horizontalMove, rb.velocity.y, 0);
            rb.AddForce(Vector3.left * force * Time.deltaTime);
            Moving = true;
            Debug.Log("Key Left Arrow has been pressed");
        }
     }
    }
  }
      //Checks if player colides with ground
      void OnCollisionEnter2D(Collision2D collider)
      {
        if (isGrounded == false)
          {
            Jump_sound.enabled = false;
            if (collider.gameObject.CompareTag("Ground"))
              {
                isGrounded = true;
                jumped = false;
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