using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Default : MonoBehaviour
{
[SerializeField] public GameObject button;
    private Rigidbody2D rb;
    public bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        clicked = true;
    }

    void Update()
    {
        
    }
}
