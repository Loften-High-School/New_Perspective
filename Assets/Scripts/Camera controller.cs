using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public Camera MenuCamera;
    public Camera PlayerCamera;
    public Camera difficulty;
    public Difficulty Difficulty;
    public menu Play;
    // Start is called before the first frame update
    void Start()
    {
        MenuCamera.enabled = true;
        difficulty.enabled = false;
        PlayerCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Play.Clicked == true)
        {
            MenuCamera.enabled = false;
            PlayerCamera.enabled = false;
            difficulty.enabled = true;
        }
        
        if (Difficulty.easy == true)
        {
            MenuCamera.enabled = false;
            difficulty.enabled = false;
            PlayerCamera.enabled = true;
        }

        if (Difficulty.medium == true)
        {
            MenuCamera.enabled = false;
            difficulty.enabled = false;
            PlayerCamera.enabled = true;
        }

        if (Difficulty.hard == true)
        {
            MenuCamera.enabled = false;
            difficulty.enabled = false;
            PlayerCamera.enabled = true;
        }

        if (Difficulty.insane == true)
        {
            MenuCamera.enabled = false;
            difficulty.enabled = false;
            PlayerCamera.enabled = true;
        }
    }
}
