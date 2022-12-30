using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModMusicButton : MonoBehaviour
{
    public static bool music = true;
    
    public Sprite musicON;
    public Sprite musicOFF;
    public Button buttonMusic;
    public AudioSource audioSource;

    public void Start()
    {
        music = true;
    }
    public void musicMute()
    {
        if (music == true)
        {
            
            audioSource.mute = true;
            buttonMusic.image.sprite = musicOFF;
            music=false;

        }
        else
        {
            audioSource.mute = false;
            buttonMusic.image.sprite = musicON;
            music=true;

        }
    }
}
