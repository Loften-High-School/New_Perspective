using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Cameras")]
    public Camera menu_Camera;
    public Camera player_Camera;
    public Camera hexagon_Camera;
    public Camera difficulty_Camera;
    public Camera gameOver_Camera;
    public Camera options_Camera;
    public Camera pause_Camera;
    public Camera controls_Camera;
    public Camera shape_Camera;

    [Header("Audio")]
    public AudioSource easy, medium, hard, insane, lobby;
    public Music_Button music;

    [Header("UI Elements")]
    public menu playButton;
    public Home homeButton;
    public Resume resumeButton;
    public Pause pauseFlag;
    public Hexagon_Pause hexPauseFlag;
    public Option_button Options_Main;    // main‐menu settings
    public Option_button Options_Pause;   // pause‐menu settings
    public List<Back_button> backArrows;  // all back arrows
    public Option_button controlsButton;
    public Button_Default shapeButton;
    public Selection squareButton, hexagonButton;
    public Difficulty difficulty;
    public Hexagon_Difficulty hexagonDifficulty;
    public GameOver gameOverFlag;

    private bool isInSettingsMenu = false;
    private bool isInPauseSettings = false;

    void Start()
    {
        lobby.enabled = true;
        ActivateCamera(menu_Camera);
        ResetUI();
    }

    void Update()
    {
        if (!gameOverFlag.isAlive)
        {
            ActivateCamera(gameOver_Camera);
            return;
        }

        // Pause toggle
        if (!pauseFlag.paused && Input.GetKeyDown(KeyCode.Tab))
        {
            pauseFlag.paused = hexPauseFlag.paused = true;
        }
        else if (pauseFlag.paused && Input.GetKeyDown(KeyCode.Tab))
        {
            ResumeFromPause();
        }

        // Resume button
        if (resumeButton.clicked)
        {
            ResumeFromPause();
            return;
        }

        // Home button
        if (homeButton.clicked)
        {
            ActivateCamera(menu_Camera);
            ResetUI();
            return;
        }

        // Play button
        if (playButton.Clicked)
        {
            ActivateCamera(difficulty_Camera);
            ResetUI();
            playButton.Clicked = false;
            return;
        }

        // Settings buttons (main and pause)
        if (Options_Main.Clicked)
        {
            EnterSettings(mainMenu: true);
            return;
        }
        if (Options_Pause.Clicked)
        {
            EnterSettings(mainMenu: false);
            return;
        }

        // Pause state
        if (pauseFlag.paused || hexPauseFlag.paused)
        {
            if (!isInSettingsMenu)
                ActivateCamera(pause_Camera);
            return;
        }

        // Back arrows
        if (backArrows.Exists(b => b.Clicked))
        {
            if (isInSettingsMenu)
            {
                if (isInPauseSettings)
                    ActivateCamera(pause_Camera);
                else
                    ActivateCamera(menu_Camera);
            }
            else
            {
                ActivateCamera(menu_Camera);
            }
            ResetUI();
            return;
        }

        // Controls and Shape under settings
        if (controlsButton.Clicked)
        {
            ActivateCamera(controls_Camera);
            ResetUI(keepPause: true);
            return;
        }
        if (shapeButton.clicked)
        {
            ActivateCamera(shape_Camera);
            ResetUI(keepPause: true);
            return;
        }

        // Difficulty selection
        if (difficulty.easy || difficulty.medium || difficulty.hard || difficulty.insane)
        {
            PlayDifficultyMusic();
            if (squareButton.Square_selected) ActivateCamera(player_Camera);
            else if (hexagonButton.Hexagon_selected) ActivateCamera(hexagon_Camera);
        }
    }

    void EnterSettings(bool mainMenu)
    {
        isInSettingsMenu = true;
        isInPauseSettings = !mainMenu;
        ActivateCamera(options_Camera);
        ResetUI(keepPause: true);
        if (mainMenu) Options_Main.Clicked = false;
        else Options_Pause.Clicked = false;
    }

    void ResumeFromPause()
    {
        pauseFlag.paused = hexPauseFlag.paused = false;
        isInSettingsMenu = false;
        isInPauseSettings = false;
        if (squareButton.Square_selected) ActivateCamera(player_Camera);
        else if (hexagonButton.Hexagon_selected) ActivateCamera(hexagon_Camera);
        else ActivateCamera(player_Camera);
        resumeButton.clicked = false;
    }

    void ActivateCamera(Camera cam)
    {
        var cams = new[] { menu_Camera, player_Camera, hexagon_Camera, difficulty_Camera,
                           gameOver_Camera, options_Camera, pause_Camera,
                           controls_Camera, shape_Camera };
        foreach (var c in cams) c.enabled = (c == cam);
    }

    void ResetUI(bool keepPause = false)
    {
        playButton.Clicked = false;
        Options_Main.Clicked = false;
        Options_Pause.Clicked = false;
        foreach (var b in backArrows) b.Clicked = false;
        resumeButton.clicked = false;
        homeButton.clicked = false;
        if (!keepPause) pauseFlag.paused = hexPauseFlag.paused = false;
        controlsButton.Clicked = false;
        shapeButton.clicked = false;
    }

    void SetAllAudio(bool on)
    {
        easy.enabled = medium.enabled = hard.enabled = insane.enabled = lobby.enabled = on;
    }

    void PlayDifficultyMusic()
    {
        SetAllAudio(false);
        if (music.ON > 0)
        {
            if (difficulty.easy) easy.enabled = true;
            else if (difficulty.medium) medium.enabled = true;
            else if (difficulty.hard) hard.enabled = true;
            else if (difficulty.insane) insane.enabled = true;
        }
    }
}
