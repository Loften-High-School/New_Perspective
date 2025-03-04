using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_button : MonoBehaviour
{
[SerializeField] public GameObject button;
    private Rigidbody2D rb;
    public bool Clicked;
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
        
    }
}
