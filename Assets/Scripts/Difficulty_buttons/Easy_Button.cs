using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy_Button : MonoBehaviour
{
[SerializeField] public GameObject button;
    public Camera difficulty;
    private Rigidbody2D rb;
    public bool EasyClicked;
    public Difficulty Difficulty;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        EasyClicked = true;
    }

    void Update()
    {
        if(EasyClicked == true)
        {
            Difficulty.easy = true;
        }
        
        if(Difficulty.medium == true|Difficulty.hard == true|Difficulty.insane == true)
        {
            EasyClicked = false;
        }
    }
}
