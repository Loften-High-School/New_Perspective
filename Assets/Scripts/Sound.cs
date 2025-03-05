using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Button : MonoBehaviour
{
[SerializeField] public GameObject button;
public Animator animator;
public AudioSource Player;
public bool clicked;
private Rigidbody2D rb;
public float ON;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ON = 1;
        animator.SetFloat("on", Mathf.Abs(ON));
    }

    void OnMouseDown()
    {
        clicked = true;
        if(clicked == true && ON > 0)
        {
            ON = -1;
            animator.SetFloat("on", -1);
            //Player.enabled = false;
            clicked = false;
        }
        
        else if(clicked == true && ON < 0)
        {
            ON = 1;
            animator.SetFloat("on", 1);
            Player.enabled = true;
            clicked = false;
        }
    }
    void Update()
    {
        
    }
}