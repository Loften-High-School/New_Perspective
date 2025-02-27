using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insane_Button : MonoBehaviour
{
[SerializeField] public GameObject button;
    public Camera difficulty;
    private Rigidbody2D rb;
    public bool InsaneClicked;
    public Difficulty Difficulty;
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
        }
        
        if(Difficulty.easy == true|Difficulty.medium == true|Difficulty.hard == true)
        {
            InsaneClicked = false;
        }
    }
}
