using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModSpeedRunButton : MonoBehaviour
{
  
    public void SpeedRunGameButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }
}
