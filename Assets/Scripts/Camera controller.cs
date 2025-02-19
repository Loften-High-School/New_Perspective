using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public Camera MenuCamera;
    public Camera PlayerCamera;
    public Difficulty Difficulty;
    // Start is called before the first frame update
    void Start()
    {
        MenuCamera.enabled = true;
        PlayerCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Difficulty.easy == true)
        {
            MenuCamera.enabled = false;
            PlayerCamera.enabled = true;
        }

        if (Difficulty.medium == true)
        {
            MenuCamera.enabled = false;
            PlayerCamera.enabled = true;
        }

        if (Difficulty.hard == true)
        {
            MenuCamera.enabled = false;
            PlayerCamera.enabled = true;
        }

        if (Difficulty.insane == true)
        {
            MenuCamera.enabled = false;
            PlayerCamera.enabled = true;
        }
    }
}
