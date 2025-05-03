using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    
    public Selection Square;
    public Selection Hexagon;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Square.clicked == true)
        {
            transform.position = new Vector3(-609f, -455f, -31f);
        }

        if(Hexagon.clicked == true)
        {
            transform.position = new Vector3(-519f, -455f, -31f);
        }
    }
}
