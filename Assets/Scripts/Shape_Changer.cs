using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape_Changer : MonoBehaviour
{
    
    public GameObject Player;
    public GameObject Hexagon;
    public GameObject Circle;
    //public GameObject Triangle;


    public Selection Hexagon_Button;
    public Selection Square_Button;
    public Selection Circle_Button;
    //public Selection Triangle_Button;


    public Movement movement;
    public Hexagon hexagon;
    public Circle_Movement circle_movement;
    //public Triangle_Movement triangle_movement;


    public Difficulty difficulty;
    public Hexagon_Difficulty Hexagon_Difficulty;
    public Circle_Difficulty circle_difficulty;
    //public Triangle_Difficulty triangle_difficulty;


    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Square_Button.Square_selected == true) && (Hexagon_Button.Hexagon_selected == false) && (Circle_Button.Circle_selected == false))
        {
            Debug.Log("Square has been chosen");
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            hexagon.enabled = false;
            Hexagon_Difficulty.enabled = false;
            difficulty.enabled = true;
            movement.enabled = true;
        }

        if ((Hexagon_Button.Hexagon_selected == true) && (Square_Button.Square_selected == false) && (Circle_Button.Circle_selected == false))
        {
            Debug.Log("Hexagon has been chosen");
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            movement.enabled = false;
            difficulty.enabled = false;
            Hexagon_Difficulty.enabled = true;
            hexagon.enabled = true;
            circle_difficulty.enabled = false;
            circle_movement.enabled = false;
        }
        
        if ((Circle_Button.Circle_selected == true) && (Hexagon_Button.Hexagon_selected == false) && (Square_Button.Square_selected == false))
        {
            Debug.Log("Circle has been chosen");
            rb.constraints = RigidbodyConstraints2D.None;
            movement.enabled = false;
            difficulty.enabled = false;
            Hexagon_Difficulty.enabled = false;
            hexagon.enabled = false;
            circle_difficulty.enabled = true;
            circle_movement.enabled = true;
        }

    }
}
