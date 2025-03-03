using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medium_Button : MonoBehaviour
{
[SerializeField] public GameObject button;
    public Camera difficulty;
    private Rigidbody2D rb;
    public bool MediumClicked;
    public Difficulty Difficulty;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        MediumClicked = true;
    }

    void Update()
    {
        if(MediumClicked == true)
        {
            Difficulty.medium = true;
        }
        
        if(Difficulty.easy == true|Difficulty.hard == true|Difficulty.insane == true)
        {
            MediumClicked = false;
        }
    }
}
