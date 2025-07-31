using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Camera : MonoBehaviour
{
    public GameObject targetObject; // The object to maintain distance from
    
    public Circle_Movement movement;
    
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
            
            transform.position = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y, targetObject.transform.position.z);
        }
    
    
    }
}
