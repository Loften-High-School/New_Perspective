using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_movement : MonoBehaviour
{
    

    [SerializeField] Difficulty Difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        if(Difficulty.easy == true)
        {
           transform.position = new Vector3 (0.7139654f, 12.40304f, -20.36209f); 
        }
            
        if(Difficulty.medium == true)
        {
           transform.position = new Vector3 (0.7139654f, 156f, -20.36209f); 
        }
    
        if(Difficulty.hard == true)
        {
           transform.position = new Vector3 (-198f, 156f, -20.36209f); 
        }

        if(Difficulty.insane == true)
        {
           transform.position = new Vector3 (-198f, 12.40304f, -20.36209f); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
