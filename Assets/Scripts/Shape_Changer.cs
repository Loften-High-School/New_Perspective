using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape_Changer : MonoBehaviour
{
    
    public GameObject Player;
    public GameObject Hexagon;
    public Button_Default Hexagon_Button;
    public Button_Default Square_Button;
    //public GameObject Triangle;
    //public GameObject Circle;
    public Movement movement;
    public Hexagon hexagon;
    public Difficulty difficulty;
    public Hexagon_Difficulty Hexagon_Difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Square_Button.clicked == true)
        {
            Debug.Log("Square has been chosen");
            Hexagon.transform.position = new Vector3 (599.6f, 27.7f, 0f);
            hexagon.enabled = false;
            Hexagon_Difficulty.enabled = false;
            difficulty.enabled = true;
            Hexagon_Button.clicked = false;
        }

        if(Hexagon_Button.clicked == true)
        {
            Debug.Log("Hexagon has been chosen");
            Player.transform.position = new Vector3 (599.6f, 27.7f, 0f);
            movement.enabled = false;
            difficulty.enabled = false;
            Hexagon_Difficulty.enabled = true;
            Square_Button.clicked = false;
        }
    }
}
