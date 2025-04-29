using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Jump_sound.enabled = false;
        ability_ready = true;
        teleported = false;
    }
    
    // Cooldown time to prevent spamming teleport
    public float lastTeleportTime = -Mathf.Infinity; // Track last teleport time


    void Teleport()
    {
        teleported = true;
        Vector3 targetPosition = teleport_spot.transform.position;
        if(ability_ready == true)
        {
          transform.position = new Vector3(teleport_spot.transform.position.x, teleport_spot.transform.position.y, 0f);
        }
    }



    public GameObject teleport_spot;
    public float teleportCooldown;
    public bool ability_ready;
    public bool teleported;
    public bool jumped;
    public Hexagon hexagon;
    public GameOver gameOver;
    public float maxSpeed;
    public float force;
    public Hexagon_Difficulty difficulty;
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

    public Hexagon_Pause pause;
    

    
    // Update is called once per frame
    void Update()
    {
        
        if ((ability_ready == true) && (teleported == false) && (jumped == true) && (isGrounded == false))
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
          hexagon.enabled = false;
        }
        else if(pause.paused == false)
        {
          hexagon.enabled = true;
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
            else if(isGrounded == false)
            {
              Teleport();
              Debug.Log("Player has telported");
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