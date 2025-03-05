using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard_Button : MonoBehaviour
{
[SerializeField] public GameObject button;
    public Camera difficulty;
    private Rigidbody2D rb;
    public bool HardClicked;
    public Difficulty Difficulty;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        HardClicked = true;
    }

    void Update()
    {
        if(HardClicked == true)
        {
            Difficulty.hard = true;
        }
    }
}
