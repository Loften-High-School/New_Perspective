using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon_shape_mover : MonoBehaviour
{
    public Pause pause;
    public Hexagon_Pause Hexagon_Pause;
    public float x;
    public float y;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((pause.paused == true) | (Hexagon_Pause.paused == true))
        {
            transform.position = new Vector3(x, y, 0f);
        }
    }
}
