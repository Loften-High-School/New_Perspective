using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
[SerializeField] public GameObject button;
    public Camera MainCamera;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);
        }
    }
}
