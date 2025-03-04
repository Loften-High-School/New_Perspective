using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public Camera MenuCamera;
    public Camera PlayerCamera;
    public Camera difficulty;
    public Camera GameOver_Camera;
    public Difficulty Difficulty;
    public menu Play;
    public GameOver gameOver;
    public AudioSource Easy;
    public AudioSource Medium;
    public AudioSource Hard;
    public AudioSource Insane;
    public AudioSource Lobby;
    public Camera Options;
    public Back_button back;
    public Sound_Button sound;
    public Music_Button music;
    public Option_button options;
    // Start is called before the first frame update
    void Start()
    {
        Lobby.enabled = true;
        Easy.enabled = false;
        Medium.enabled = false;
        Hard.enabled = false;
        Insane.enabled = false;
        MenuCamera.enabled = true;
        difficulty.enabled = false;
        PlayerCamera.enabled = false;
        GameOver_Camera.enabled = false;
        Options.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver.isAlive == true)
        {
            if(Play.Clicked == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = true;
                GameOver_Camera.enabled = false;
                Options.enabled = false;
            }

            if(options.Clicked == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options.enabled = true;
            }

            if(back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options.enabled = false;
            }
        
            if (Difficulty.easy == true)
            {
                Lobby.enabled = false;
                Easy.enabled = true;
                Medium.enabled = false;
                Hard.enabled = false;
                Insane.enabled = false;
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options.enabled = false;
            }

            if (Difficulty.medium == true)
            {
                Lobby.enabled = false;
                Easy.enabled = false;
                Medium.enabled = true;
                Hard.enabled = false;
                Insane.enabled = false;
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options.enabled = false;
            }

            if (Difficulty.hard == true)
            {
                Lobby.enabled = false;
                Easy.enabled = false;
                Medium.enabled = false;
                Hard.enabled = true;
                Insane.enabled = false;
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options.enabled = false;
            }

            if (Difficulty.insane == true)
            {
                Lobby.enabled = false;
                Easy.enabled = false;
                Medium.enabled = false;
                Hard.enabled = false;
                Insane.enabled = true;
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options.enabled = false;
            }
        }

        if(gameOver.isAlive == false)
        {
            Lobby.enabled = false;
            Easy.enabled = false;
            Medium.enabled = false;
            Hard.enabled = false;
            Insane.enabled = false;
            MenuCamera.enabled = false;
            difficulty.enabled = false;
            GameOver_Camera.enabled = true;
            Options.enabled = false;
        }
    }
}
