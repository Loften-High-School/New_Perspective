using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Cameras")]
    public Camera MenuCamera;
    public Camera PlayerCamera;
    public Camera HexagonCamera;
    public Camera DifficultyCamera;
    public Camera GameOver_Camera;
    public Camera Options_Camera;
    public Camera Pause_Camera;
    public Camera Controls_Camera;
    public Camera Shape_Camera;

    [Header("Audio Sources")]
    public AudioSource Easy;
    public AudioSource Medium;
    public AudioSource Hard;
    public AudioSource Insane;
    public AudioSource Lobby;

    [Header("UI Elements")]
    public Difficulty difficulty;
    public menu Play;
    public GameOver gameOver;
    public Option_button Options_Main;
    public Option_button Options_Pause;
    public Back_button Back_Button;
    public List<Back_button> _Back_Buttons;
    public Music_Button music;
    public Resume resume;
    public Home home;
    public Pause pause;
    public Hexagon_Pause Hexagon_Pause;
    public Option_button Controls_Button;
    public Button_Default Shape_Button;
    public Selection Square_Button;
    public Selection Hexagon_Button;
    public Hexagon_Difficulty hexagonDifficulty;

    void Start()
    {
        SetAllAudio(false);
        Lobby.enabled = true;

        EnableOnlyCamera(MenuCamera);

        ResetUIStates();
    }

    void Update()
    {
        if (gameOver.isAlive)
        {
            if (music.ON < 0) Lobby.enabled = false;

            if (Play.Clicked) HandlePlayClicked();
            if (home.clicked) HandleHomeClicked();

            HandlePauseCamera();

            HandleBackButtons();
            HandleOptionControlsShape();
            HandleResume();
            HandleDifficultySelection();
        }
        else
        {
            SetAllAudio(false);
            EnableOnlyCamera(GameOver_Camera);
        }

        if ((pause.paused == true) || (Hexagon_Pause.paused == true))
        {
            PlayerCamera.enabled = false;
            HexagonCamera.enabled = false;
            EnableOnlyCamera(Pause_Camera);
            if (Options_Pause.Clicked == true)
            {
                EnableOnlyCamera(Options_Camera);
            }
        }
        else
        {
            Pause_Camera.enabled = false;
        }
    }

    void HandlePauseCamera()
    {
        if ((pause.paused == true) || (Hexagon_Pause.paused == true) && (Options_Pause.Clicked == true))
        {
            Debug.Log("Pause triggered: showing Pause_Camera");
            EnableOnlyCamera(Pause_Camera);
            if(Pause_Camera.enabled == true)
            {
                Debug.Log("Pause Camera is on");
            }
        }
    }

    void HandlePlayClicked()
    {
        EnableOnlyCamera(DifficultyCamera);
        ResetUIStates();
        Play.Clicked = false;
    }

    void HandleHomeClicked()
    {
        SetAllAudio(false);
        EnableOnlyCamera(MenuCamera);
        ResetUIStates();
        difficulty.enabled = true;
        hexagonDifficulty.enabled = false;
        pause.paused = false;
        Hexagon_Pause.paused = false;
    }

    void HandleBackButtons()
    {
        foreach (var back in _Back_Buttons)
        {
            if (back.Clicked)
            {
                if (Options_Main.Clicked)
                {
                    EnableOnlyCamera(MenuCamera);
                }
                else if (Options_Pause.Clicked)
                {
                    EnableOnlyCamera(Pause_Camera);
                }
                ResetUIStates();
                break;
            }
        }

        if (Options_Main.Clicked && !Back_Button.Clicked)
        {
            EnableOnlyCamera(Options_Camera);
        }
        else if (Options_Pause.Clicked && !Back_Button.Clicked)
        {
            EnableOnlyCamera(Options_Camera);
        }
    }

    void HandleOptionControlsShape()
    {
        if (Controls_Button.Clicked)
        {
            EnableOnlyCamera(Controls_Camera);
            ResetUIStates();
        }
        else if (Shape_Button.clicked)
        {
            EnableOnlyCamera(Shape_Camera);
            ResetUIStates();
        }
    }

    void HandleResume()
    {
        if (resume.clicked)
        {
            EnableOnlyCamera(null);
            PlayerCamera.enabled = Square_Button.Square_selected;
            HexagonCamera.enabled = Hexagon_Button.Hexagon_selected;

            Pause_Camera.enabled = false;

            resume.clicked = false;
            pause.paused = false;
            Hexagon_Pause.paused = false;
        }
    }

    void HandleDifficultySelection()
    {
        if ((difficulty.easy == true) || (difficulty.medium == true) || (difficulty.hard == true) || (difficulty.insane == true))
        {
            PlayDifficultyMusic();
            EnableOnlyCamera(null);
            PlayerCamera.enabled = Square_Button.Square_selected;
            HexagonCamera.enabled = Hexagon_Button.Hexagon_selected;

            if ((pause.paused == true) || (Hexagon_Pause.paused == true))
            {
                PlayerCamera.enabled = false;
                HexagonCamera.enabled = false;
                if (Options_Pause.Clicked) 
                {
                    Options_Camera.enabled = true;
                }
            }
            else
            {
                Pause_Camera.enabled = false;
            }
        }
    }

    void SetAllAudio(bool state)
    {
        Easy.enabled = state;
        Medium.enabled = state;
        Hard.enabled = state;
        Insane.enabled = state;
        Lobby.enabled = state;
    }

    void PlayDifficultyMusic()
    {
        SetAllAudio(false);
        if (music.ON > 0)
        {
            if (difficulty.easy == true) 
            {
                Easy.enabled = true;
            }
            else if (difficulty.medium == true) 
            {
                Medium.enabled = true;
            }
            else if (difficulty.hard == true)
            {
                Hard.enabled = true;
            }
            else if (difficulty.insane == true) 
            {
                Insane.enabled = true;
            }
        }
    }

    void EnableOnlyCamera(Camera camToEnable)
    {
        foreach (Camera cam in new[] { MenuCamera, PlayerCamera, HexagonCamera, DifficultyCamera, GameOver_Camera, Options_Camera, Pause_Camera, Controls_Camera, Shape_Camera })
        {
            cam.enabled = cam == camToEnable;
        }
    }

    void ResetUIStates()
    {
        Play.Clicked = false;
        Options_Main.Clicked = false;
        Options_Pause.Clicked = false;
        foreach (var back in _Back_Buttons) back.Clicked = false;
        resume.clicked = false;
        home.clicked = false;
        pause.paused = false;
        Hexagon_Pause.paused = false;
        Controls_Button.Clicked = false;
        Shape_Button.clicked = false;
    }
}