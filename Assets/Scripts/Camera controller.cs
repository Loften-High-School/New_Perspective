using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public Camera MenuCamera;
    public Camera Player;
    // Start is called before the first frame update
    void Start()
    {
        MenuCamera.enabled = true;
        Player.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
