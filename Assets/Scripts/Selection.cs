using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    public bool Hexagon_selected;
    public bool Square_selected;
    public bool Circle_selected;


    public Selection Square_Button;
    public Selection Hexagon_Button;
    public Selection Circle_Button;

    
    [SerializeField] public GameObject button;
    private Rigidbody2D rb;
    public bool clicked;
    
    // Start is called before the first frame update
    void Start()
    {
        Square_selected = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        clicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Hexagon_Button.clicked == true) && (Square_selected == true)|(Circle_selected == true))
        {
            Hexagon_selected = true;
            Square_selected = false;
            Circle_selected = false;
            Hexagon_Button.clicked = true;
            Square_Button.clicked = false;
            Circle_Button.clicked = false;
        }

        if ((Square_Button.clicked == true) && (Hexagon_selected == true)|(Circle_selected == true))
        {
            Hexagon_selected = false;
            Square_selected = true;
            Circle_selected = false;
            Square_Button.clicked = true;
            Hexagon_Button.clicked = false;
            Circle_Button.clicked = false;
        }

        if ((Circle_Button.clicked == true) && (Hexagon_selected == true) | (Square_selected == true))
        {
            Square_selected = false;
            Hexagon_selected = false;
            Circle_selected = true;
            Square_Button.clicked = false;
            Hexagon_Button.clicked = false;
            Circle_Button.clicked = true;
        }
    }
}
