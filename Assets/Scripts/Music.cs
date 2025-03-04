using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Button : MonoBehaviour
{
[SerializeField] public GameObject button;
public Animator animator;
public AudioSource Easy;
public AudioSource Medium;
public AudioSource Hard;
public AudioSource Insane;
public bool clicked;
private Rigidbody2D rb;
public float ON;

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
        animator.SetFloat("on", Mathf.Abs(ON));

        if(clicked == true)
        {
            animator.SetFloat("on", -1);
            Easy.enabled = false;
            Medium.enabled = false;
            Hard.enabled = false;
            Insane.enabled = false;
        }
    }
}
