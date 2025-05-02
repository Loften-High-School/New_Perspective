using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public GameObject targetObject; // The object to maintain distance from
    
    public float targetDistance; // The desired distance

    public float moveSpeed; // Adjust this value for desired speed
    
    public Hexagon hexagon;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        {
            // Get the position of the target sprite
            Vector3 targetPosition = targetObject.transform.position;

            if(hexagon.horizontalMove == -1)
            {
                transform.position = new Vector3(targetObject.transform.position.x - targetDistance, transform.position.y, transform.position.z);
            }
            else if(hexagon.horizontalMove == 1)
            {
                transform.position = new Vector3(targetObject.transform.position.x + targetDistance, transform.position.y, transform.position.z);
            }
        }
    
    
    }
}
