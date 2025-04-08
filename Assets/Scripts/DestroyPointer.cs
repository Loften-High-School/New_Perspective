using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPointer : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter2D (Collision2D collider)
    {  
        {
            if(collider.gameObject.CompareTag("Player"))
            {
                Debug.Log("You got a point");
                Destroy(gameObject);
            }
        }
    }
}
