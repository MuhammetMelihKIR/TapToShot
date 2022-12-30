using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerBar : MonoBehaviour
{
    public static int bar;
    public Slider barSlider; 

    public static bool leftPotDestroy=false;
    public static bool rightPotDestroy=false;
    
   
    
    
   
     

    public void Start()
    {

        bar = 0;
        barSlider.value = bar;

    }

    private void Update()
    {
        barSlider.value = bar;
        if (pauseButton.gamestop == false)
        {
            barSlider.value = bar;
            bar += 1;
        }
       

        if (bar>220)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            
            
            
        }

      
    }
    

}
