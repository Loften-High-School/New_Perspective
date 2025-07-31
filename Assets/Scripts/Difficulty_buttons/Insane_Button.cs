using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insane_Button : MonoBehaviour
{
[SerializeField] public GameObject button;
    private Rigidbody2D rb;
    public bool InsaneClicked;
    public Difficulty Difficulty;
    public Hexagon_Difficulty DIFFICULTY;
    public Circle_Difficulty difficulty;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        InsaneClicked = true;
    }

    void Update()
    {
        if(InsaneClicked == true)
        {
            Difficulty.insane = true;
            DIFFICULTY.insane = true;
            difficulty.insane = true;
        }
    }
}
