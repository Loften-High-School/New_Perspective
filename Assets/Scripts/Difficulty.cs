using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    [SerializeField] GameObject Player;
    
    public bool easy;
    public bool medium;
    public bool hard;
    public bool insane;
    private Rigidbody2D rb;
    public Easy_Button Easy_Button;
    public Medium_Button Medium_Button;
    public Hard_Button Hard_Button;
    public Insane_Button Insane_Button;
    public Pause pause;
    public Hexagon_Pause hexagon;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(easy == true && Easy_Button.EasyClicked == true)
        {
            medium = false;
            hard = false;
            insane = false;
            transform.position = new Vector3 (1.2f, -1.66f, 0f);
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            Debug.Log("Easy Mode selected");
            Easy_Button.EasyClicked = false;
        }
        if(medium == true && Medium_Button.MediumClicked == true)
        {
            easy = false;
            hard = false;
            insane = false;
            transform.position = new Vector3 (1.2f, 141.88f, 0f);
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            Debug.Log("Medium Mode selected");
            Medium_Button.MediumClicked = false;
        }
        if(hard == true && Hard_Button.HardClicked == true)
        {
            medium = false;
            easy = false;
            insane = false;
            transform.position = new Vector3 (-197.57f, 141.88f, 0f);
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            Debug.Log("Hard Mode selected");
            Hard_Button.HardClicked = false;
        }
        if(insane == true && Insane_Button.InsaneClicked == true)
        {
            medium = false;
            hard = false;
            easy = false;
            transform.position = new Vector3 (-197.57f, -1.26f, 0f);
            rb.constraints = RigidbodyConstraints2D.None;
            Debug.Log("Insane Mode selected");
            Insane_Button.InsaneClicked = false;
        }

        if(pause.paused == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        if(hexagon.paused == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
