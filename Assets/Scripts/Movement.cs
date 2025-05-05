using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public Movement movement;
    public GameOver gameOver;
    public float maxSpeed;
    public float force;
    public Difficulty difficulty;
    public AudioSource Jump_sound;
    public Sound_Button Sound;
  //Jumpforce variable
  [SerializeField] int jumpforce;

    //a true or false variable that checks the ground
    [SerializeField] bool isGrounded = false;

    [SerializeField] float horizontalMove;
    
    [SerializeField] bool Moving;
    
    public Animator animator;
    
    private Rigidbody2D rb;

    public Pause pause;
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
      if ((Input.GetKeyDown(KeyCode.D))|(Input.GetKey(KeyCode.D)))
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
      if ((Input.GetKeyDown(KeyCode.A))|(Input.GetKey(KeyCode.A)))
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
            rb.velocity = new Vector3(15 * force * horizontalMove, rb.velocity.y, 0);
            rb.AddForce(Vector3.right * force * Time.deltaTime);
            Moving = true;
            Debug.Log("Right Arrow Key has been pressed");
        }
      if ((Input.GetKeyDown(KeyCode.LeftArrow))|(Input.GetKey(KeyCode.LeftArrow)))    
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