using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Pause : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool paused;
    public Circle_Movement circle_movement;
    public Circle_Difficulty circle_difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Game has been paused");
            paused = true;
        }

        if(paused == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
        
        if(paused == false)
        {
            circle_movement.enabled = true;
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }
}
