using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
[SerializeField] public GameObject button;
public Animator animator;
public AudioSource Player;
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
            Player.enabled = false;
        }
    }
}
