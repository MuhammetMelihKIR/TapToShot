
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseButton : MonoBehaviour
{
    
    public static bool gamestop = false;
    public Sprite pauseImage;
    public Sprite startImage;
    public Button Button;

    


    public void stopGame()
    {
        if (gamestop == false)
        {
            
            Button.image.sprite = startImage;
            Time.timeScale = 0f;
            gamestop = true;
        }
        else
        {
            
            Button.image.sprite = pauseImage;
            Time.timeScale = 1f;
            gamestop = false;
        }


    }

   
}
