using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
[SerializeField] public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        //m_Camera = Camera.Main;
    }

    // Update is called once per frame
    void Update()
    {
        /*Mouse mouse = Mouse.current;
       if (mouse.leftButton.wasPressedThisFrame)
       {
           Vector3 mousePosition = mouse.position.ReadValue();
           Ray ray = m_Camera.ScreenPointToRay(mousePosition);
           if (Physics.Raycast(ray, out RaycastHit hit))
           {
               // Use the hit variable to determine what was clicked on.
           }
       }*/
    }
}
