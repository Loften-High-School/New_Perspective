using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape_mover : MonoBehaviour
{
    public Difficulty difficulty;
    public float x;
    public float y;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((difficulty.easy == true) | (difficulty.medium == true) | (difficulty.hard == true) | (difficulty.insane == true))
        {
            transform.position = new Vector3(x, y, 0f);
        }
    }
}
