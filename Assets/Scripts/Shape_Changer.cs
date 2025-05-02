using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape_Changer : MonoBehaviour
{
    
    public GameObject Player;
    public GameObject Hexagon;
    public SpriteRenderer player;
    public SpriteRenderer hexagon;
    public BoxCollider2D _player;
    public PolygonCollider2D _hexagon;
    public Movement movement;
    public Hexagon _Hexagon;
    public Button_Default Hexagon_Button;
    public Button_Default Square_Button;
    public Rigidbody2D PLAYER;
    public Rigidbody2D HEXAGON;
    //public GameObject Triangle;
    //public GameObject Circle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Square_Button.clicked == true)
        {
            Debug.Log("Square has been chosen");
            player.enabled = true;
            _player.enabled = true;
            movement.enabled = true;
            hexagon.enabled = false;
            _hexagon.enabled = false;
            _Hexagon.enabled = false;
            HEXAGON.constraints= RigidbodyConstraints2D.FreezeRotation;
            HEXAGON.constraints= RigidbodyConstraints2D.FreezePosition;
        }

        if(Hexagon_Button.clicked == true)
        {
            Debug.Log("Hexagon has been chosen");
            player.enabled = false;
            _player.enabled = false;
            movement.enabled = false;
            hexagon.enabled = true;
            _hexagon.enabled = true;
            _Hexagon.enabled = true;
            PLAYER.constraints= RigidbodyConstraints2D.FreezeRotation;
            PLAYER.constraints= RigidbodyConstraints2D.FreezePosition;
        }
    }
}
