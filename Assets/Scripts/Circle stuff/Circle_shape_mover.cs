using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_shape_mover : MonoBehaviour
{
    public float x;
    public float y;
    public Home home;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(home.clicked == true)
        {
            transform.position = new Vector3(x, y, 0f);
        }
    }
}
