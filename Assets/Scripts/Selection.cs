using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    public bool Hexagon_selected;
    public bool Square_selected;
    public Selection Square_Button;
    public Selection Hexagon_Button;
    [SerializeField] public GameObject button;
    private Rigidbody2D rb;
    public bool clicked;
    
    // Start is called before the first frame update
    void Start()
    {
        Hexagon_selected = false;
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
        if(Hexagon_Button.clicked == true)
        {
            Hexagon_selected = true;
            Square_selected = false;
            Square_Button.clicked = false;
        }
        else if(Square_Button.clicked == true)
        {
            Hexagon_selected = false;
            Square_selected = true;
            Hexagon_Button.clicked = false;
        }
    }
}
