using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medium_level_music : MonoBehaviour
{
    public Difficulty difficulty;
    public Hexagon_Difficulty hexagon_difficulty;
    public AudioSource audioSource;
    public bool playing;
    public Pause pause;
    public Hexagon_Pause Hexagon_Pause;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource.enabled = false;
        playing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((difficulty.medium == true) || (hexagon_difficulty.medium == true))
        {
            playing = true;
            Debug.Log("medium music playing");
        }
        
        if((difficulty.medium == false) || (hexagon_difficulty.medium == false))
        {
            playing = false;
        }

        if((pause.paused == true) || (Hexagon_Pause.paused == true))
        {
            playing = false;
        }

        if(playing == true)
        {
            audioSource.enabled = true;
        }
        else if(playing == false)
        {
            audioSource.enabled = false;
        }
    }
}
