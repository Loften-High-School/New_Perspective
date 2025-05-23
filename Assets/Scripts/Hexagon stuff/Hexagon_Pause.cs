using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon_Pause : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool paused;
    public Hexagon hexagon;
    public Hexagon_Difficulty difficulty;
    
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
            hexagon.enabled = true;
            rb.constraints = RigidbodyConstraints2D.None;
            if(difficulty.easy|difficulty.medium|difficulty.hard == true)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
