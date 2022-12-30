using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModButtons : MonoBehaviour
{

    public void RestartButtom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void firstSceneButton()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
    }
}
