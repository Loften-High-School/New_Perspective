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
    public Hexagon_Difficulty DIFFICULTY;
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
            DIFFICULTY.medium = true;
        }
    }
}
