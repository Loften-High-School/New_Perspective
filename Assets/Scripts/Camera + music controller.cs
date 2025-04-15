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
    public Camera Controls_camera;
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
    public Back_button _back;
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
        Controls_camera.enabled = false;
        Play.Clicked = false;
        Options.Clicked = false;
        Back.Clicked = false;
        _back.Clicked = false;
        back.Clicked = false;
        Pause_Camera.enabled = false;
        resume.clicked = false;
        home.clicked = false;
        pause.paused = false;
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
                home.clicked = false;
                Controls_camera.enabled = false;
            }

            if(home.clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                Difficulty.easy = false;
                Difficulty.medium = false;
                Difficulty.hard = false;
                Difficulty.insane = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                options.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
                pause.paused = false;
                Controls_camera.enabled = false;
            }

            if(pause.paused == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options.Clicked = false;
                Pause_Camera.enabled = true;
                Controls_camera.enabled = false;
            }

            if(Back.Clicked == true)
            {
                if(Options.Clicked == true)
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
                    Controls_camera.enabled = false;
                }
                
                if(options.Clicked == true)
                {
                    MenuCamera.enabled = false;
                    PlayerCamera.enabled = false;
                    difficulty.enabled = false;
                    GameOver_Camera.enabled = false;
                    Options_Camera.enabled = false;
                    options.Clicked = false;
                    Play.Clicked = false;
                    back.Clicked = false;
                    Back.Clicked = false;
                    Pause_Camera.enabled = true;
                    Controls_camera.enabled = false;
                }
            }

            if(back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
            }

            if(_back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                _back.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
            }

            if(Options.Clicked == true && (Back.Clicked == false))
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = true;
                options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
            }

            if(options.Clicked == true && (Back.Clicked == false))
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = true;
                Play.Clicked = false;
                Options.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
            }

            if(resume.clicked == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = true;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Play.Clicked = false;
                Pause_Camera.enabled = false;
                resume.clicked = false;
                pause.paused = false;
                Controls_camera.enabled = false;
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
                GameOver_Camera.enabled = false;
                Controls_camera.enabled = false;
                
                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                    PlayerCamera.enabled = true;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    if(options.Clicked == true)
                    {
                        Options_Camera.enabled = true;
                    }
                }
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
                GameOver_Camera.enabled = false;
                Controls_camera.enabled = false;
                
                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                    PlayerCamera.enabled = true;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    if(options.Clicked == true)
                    {
                        Options_Camera.enabled = true;
                    }
                }
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
                GameOver_Camera.enabled = false;
                Controls_camera.enabled = false;
                
                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                    PlayerCamera.enabled = true;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    if(options.Clicked == true)
                    {
                        Options_Camera.enabled = true;
                    }
                }
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
                GameOver_Camera.enabled = false;
                Controls_camera.enabled = false;
                
                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                    PlayerCamera.enabled = true;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    if(options.Clicked == true)
                    {
                        Options_Camera.enabled = true;
                    }
                }
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
            Controls_camera.enabled = false;
        }
    }
}