using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public Camera MenuCamera;
    public Camera PlayerCamera;
    public Camera HexagonCamera;
    public Camera difficulty;
    public Camera GameOver_Camera;
    public Camera Options_Camera;
    public Camera Pause_Camera;
    public Camera Controls_camera;
    public Camera Shape_Camera;
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
    public Back_button _Back;
    public Option_button Controls;
    public Button_Default Shape_Button;
    public Selection Square_Button;
    public Selection Hexagon_Button;
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
        HexagonCamera.enabled = false;
        GameOver_Camera.enabled = false;
        Options_Camera.enabled = false;
        Controls_camera.enabled = false;
        Shape_Camera.enabled = false;
        Play.Clicked = false;
        Options.Clicked = false;
        Back.Clicked = false;
        _back.Clicked = false;
        _Back.Clicked = false;
        back.Clicked = false;
        Pause_Camera.enabled = false;
        resume.clicked = false;
        home.clicked = false;
        pause.paused = false;
        Controls.Clicked = false;
        Shape_Button.clicked = false;
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
                HexagonCamera.enabled = false;
                difficulty.enabled = true;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
                home.clicked = false;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }


            if(home.clicked == true)
            {
                Easy.enabled = false;
                Medium.enabled = false;
                Hard.enabled = false;
                Insane.enabled = false;
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                Options.Clicked = false;
                Back.Clicked = false;
                _back.Clicked = false;
                _Back.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
                pause.paused = false;
                home.clicked = false;
            }

            if(pause.paused == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options.Clicked = false;
                Pause_Camera.enabled = true;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }

            if(Back.Clicked == true)
            {
                if(Options.Clicked == true)
                {
                    MenuCamera.enabled = true;
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = false;
                    difficulty.enabled = false;
                    GameOver_Camera.enabled = false;
                    Options_Camera.enabled = false;
                    Options.Clicked = false;
                    Play.Clicked = false;
                    back.Clicked = false;
                    _Back.Clicked = false;
                    Back.Clicked = false;
                    Pause_Camera.enabled = false;
                    Controls_camera.enabled = false;
                    Controls.Clicked = false;
                    Shape_Camera.enabled = false;
                    Shape_Button.clicked = false;
                }
                
                if(options.Clicked == true)
                {
                    MenuCamera.enabled = false;
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = false;
                    difficulty.enabled = false;
                    GameOver_Camera.enabled = false;
                    Options_Camera.enabled = false;
                    options.Clicked = false;
                    Play.Clicked = false;
                    back.Clicked = false;
                    _Back.Clicked = false;
                    Back.Clicked = false;
                    Pause_Camera.enabled = true;
                    Controls_camera.enabled = false;
                    Controls.Clicked = false;
                    Shape_Camera.enabled = false;
                    Shape_Button.clicked = false;
                }
            }

            if(back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                _Back.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }

            if(_back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                _back.Clicked = false;
                _Back.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }

            if(_Back.Clicked == true)
            {
                MenuCamera.enabled = true;
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Options.Clicked = false;
                options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                _back.Clicked = false;
                _Back.Clicked = false;
                Back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }

            if(Controls.Clicked == true)
            {
                MenuCamera.enabled = false;
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
                Controls_camera.enabled = true;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }

            if(Shape_Button.clicked == true)
            {
                MenuCamera.enabled = false;
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
                Shape_Camera.enabled = true;
                Shape_Button.clicked = false;
            }

            if(Options.Clicked == true && (Back.Clicked == false))
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = true;
                options.Clicked = false;
                Play.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }

            if(options.Clicked == true && (Back.Clicked == false))
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = true;
                Play.Clicked = false;
                Options.Clicked = false;
                back.Clicked = false;
                Pause_Camera.enabled = false;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
            }

            if(resume.clicked == true)
            {
                MenuCamera.enabled = false;
                PlayerCamera.enabled = true;
                HexagonCamera.enabled = true;
                difficulty.enabled = false;
                GameOver_Camera.enabled = false;
                Options_Camera.enabled = false;
                Play.Clicked = false;
                Pause_Camera.enabled = false;
                resume.clicked = false;
                pause.paused = false;
                Controls_camera.enabled = false;
                Controls.Clicked = false;
                Shape_Camera.enabled = false;
                Shape_Button.clicked = false;
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
                Controls.Clicked = false;
                
                if(Square_Button.Square_selected == true)
                {
                    PlayerCamera.enabled = true;
                    HexagonCamera.enabled = false;
                }
                else if(Hexagon_Button.Hexagon_selected == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = true;
                }

                
                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = false;
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
                Controls.Clicked = false;
                
                if(Square_Button.Square_selected == true)
                {
                    PlayerCamera.enabled = true;
                    HexagonCamera.enabled = false;
                }
                else if(Hexagon_Button.Hexagon_selected == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = true;
                }

                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = false;
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
                Controls.Clicked = false;
                
                if(Square_Button.Square_selected == true)
                {
                    PlayerCamera.enabled = true;
                    HexagonCamera.enabled = false;
                }
                else if(Hexagon_Button.Hexagon_selected == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = true;
                }

                
                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = false;
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
                Controls.Clicked = false;
                
                if(Square_Button.Square_selected == true)
                {
                    PlayerCamera.enabled = true;
                    HexagonCamera.enabled = false;
                }
                else if(Hexagon_Button.Hexagon_selected == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = true;
                }

                
                if(pause.paused == false)
                {
                    Pause_Camera.enabled = false;
                }
                else if(pause.paused == true)
                {
                    PlayerCamera.enabled = false;
                    HexagonCamera.enabled = false;
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
            Controls.Clicked = false;
            Shape_Camera.enabled = false;
            Shape_Button.clicked = false;
        }
    }
}