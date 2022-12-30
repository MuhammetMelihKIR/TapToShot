using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ModPlayerBar : MonoBehaviour
{
    public static int bar;
    public Slider barSlider; 

    public static bool leftPotDestroy=false;
    public static bool rightPotDestroy=false;

    public void Start()
    {

        bar = 0;
        barSlider.value = 0;
        
    }

    private void Update()
    {
        barSlider.value = bar;
        if (ModPauseButton.gamestop == false && ModScoreManager.SRMscoreValue<=5)
        {
            
            barSlider.maxValue = 200;
            
            barSlider.value = bar;
            
            bar += 1;
            if (bar > 201)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        else if(ModPauseButton.gamestop == false && ModScoreManager.SRMscoreValue >= 6 &&  ModScoreManager.SRMscoreValue <= 9)
        {
            barSlider.maxValue = 170;
            
            
            bar += 1;
            if (bar > 171)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        else if (ModPauseButton.gamestop == false && ModScoreManager.SRMscoreValue >= 10 && ModScoreManager.SRMscoreValue <= 15)
        {
            barSlider.maxValue = 150;
            
            
            bar += 1;
            if (bar > 151)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        else if (ModPauseButton.gamestop == false && ModScoreManager.SRMscoreValue >= 16 && ModScoreManager.SRMscoreValue <= 21)
        {
            barSlider.maxValue = 130;
            
            
            bar += 1;
            if (bar > 131)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        else if (ModPauseButton.gamestop == false && ModScoreManager.SRMscoreValue >= 22 && ModScoreManager.SRMscoreValue <= 27)
        {
            
            barSlider.maxValue = 100;
            
            
            bar += 1;
            if (bar > 101)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
       
        else if (ModPauseButton.gamestop == false && ModScoreManager.SRMscoreValue >=28)
        {
            
            barSlider.maxValue = 90;
           
            
            bar += 1;
            if (bar > 91)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        









    }
    

}
