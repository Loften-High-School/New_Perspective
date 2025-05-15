using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool isAlive;
    public int restart;
    public Quit quit;
    public Camera GameOver_Camera;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        Debug.Log ("You are ok :D");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(restart);
        }

        if(isAlive == false)
        {
            GameOver_Camera.enabled = true;
        }
        
        if(quit.Clicked == true)
        {
            Application.Quit();
        }
    }
}
