using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
[SerializeField] public GameObject button;
public Animator animator;
public AudioSource Easy;
public AudioSource Medium;
public AudioSource Hard;
public AudioSource Insane;
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
        

        if(clicked == true)
        {
            Easy.enabled = false;
            Medium.enabled = false;
            Hard.enabled = false;
            Insane.enabled = false;
        }
    }
}
