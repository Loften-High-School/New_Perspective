using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hard_level_music : MonoBehaviour
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
        if((difficulty.hard == true) || (hexagon_difficulty.hard == true))
        {
            playing = true;
            Debug.Log("hard music playing");
        }
        
        if((difficulty.hard == false) || (hexagon_difficulty.hard == false))
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
