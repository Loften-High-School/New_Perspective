using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    
    public Button_Default Square;
    public Button_Default Hexagon;
    
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
            Hexagon.clicked = false;
            Square.clicked = false;
        }

        if(Hexagon.clicked == true)
        {
            transform.position = new Vector3(-519f, -455f, -31f);
            Square.clicked = false;
            Hexagon.clicked = false;
        }
    }
}
