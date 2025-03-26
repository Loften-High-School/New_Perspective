using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool clicked;
    public GameObject button;
    public Difficulty difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        clicked = true;
    }

    void Update()
    {

    }
}
