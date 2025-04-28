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
    float currentDistance = Vector3.Distance(transform.position, targetObject.transform.position);

        {
            // Get the position of the target sprite
            Vector3 targetPosition = targetObject.transform.position;

            if(hexagon.horizontalMove == -1)
            {
                new Vector3(transform.position.x - 35f, transform.position.y, transform.position.z);
            }
            else if(hexagon.horizontalMove == 1)
            {
                new Vector3(transform.position.x + 35f, transform.position.y, transform.position.z);
            }
        }
    
    
    }
}
