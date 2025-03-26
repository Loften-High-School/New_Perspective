using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public Camera MenuCamera;
    public Camera PlayerCamera;
    public Camera difficulty;
    public Camera GameOver_Camera;
    public Camera Options_Camera;
    public Camera Pause_Camera;
    public Difficulty Difficulty;
    public menu Play;
    public GameOver gameOver;
    public AudioSource Easy;
    public AudioSource Medium;
    public AudioSource Hard;
    public AudioSource Insane;
    public AudioSource Lobby;
    public Option_button Options;
    public Option_button options;
    public Back_button Back;
    public Music_Button music;
    public Back_button back;
    public Resume resume;
    public Home home;
    public Pause pause;
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
        Options_Camera.enabled = false;
        Play.Clicked = false;
        Options.Clicked = false;
        Back.Clicked = false;
        back.Clicked = false;
        Pause_Camera.enabled = false;
        resume.clicked = false;
        home.clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver.isAlive == true)
        {
            if(music.ON < 0)
            {
                Lobby.enabled = false;
            }
            
            if(Play.Clicked == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = true;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
            }

            if(pause.paused == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = true;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = true;
            }

            if(Back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                Play.Clicked = false;
                Back.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
            }

            if(back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
            }

            if(Options.Clicked == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = true;
                Play.Clicked = false;
                Back.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
            }

            if(options.Clicked == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = true;
                Play.Clicked = false;
                Back.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
            }
        
            if (Difficulty.easy == true)
            {
                if(music.ON < 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = false;
                    Medium.enabled = false;
                    Hard.enabled = false;
                    Insane.enabled = false;
                }
                else if(music.ON > 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = true;
                    Medium.enabled = false;
                    Hard.enabled = false;
                    Insane.enabled = false;
                }
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Pause_Camera.enabled = false;
            }

            if (Difficulty.medium == true)
            {
                if(music.ON < 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = false;
                    Medium.enabled = false;
                    Hard.enabled = false;
                    Insane.enabled = false;
                }
                else if(music.ON > 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = false;
                    Medium.enabled = true;
                    Hard.enabled = false;
                    Insane.enabled = false;
                }
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Pause_Camera.enabled = false;
            }

            if (Difficulty.hard == true)
            {
                if(music.ON < 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = false;
                    Medium.enabled = false;
                    Hard.enabled = false;
                    Insane.enabled = false;
                }
                else if(music.ON > 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = false;
                    Medium.enabled = false;
                    Hard.enabled = true;
                    Insane.enabled = false;
                }
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Pause_Camera.enabled = false;
            }

            if (Difficulty.insane == true)
            {
                if(music.ON < 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = false;
                    Medium.enabled = false;
                    Hard.enabled = false;
                    Insane.enabled = false;
                }
                else if(music.ON > 0)
                {
                    Lobby.enabled = false;
                    Easy.enabled = false;
                    Medium.enabled = false;
                    Hard.enabled = false;
                    Insane.enabled = true;
                }
                MenuCamera.enabled = false;
                difficulty.enabled = false;
                PlayerCamera.enabled = true;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Pause_Camera.enabled = false;
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
            Options_Camera.enabled = false;
            Pause_Camera.enabled = false;
        }
    }
}
