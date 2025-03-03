using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
[SerializeField] public GameObject button;
    public Camera MainCamera;
    private Rigidbody2D rb;
    public bool Clicked;
    public Difficulty difficulty;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        Clicked = true;
    }

    void Update()
    {
        if(difficulty.easy == true|difficulty.medium == true|difficulty.hard == true|difficulty.insane == true)
        {
            Clicked = false;
        }
    }
}
