using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class saveScore : MonoBehaviour
{
    [SerializeField] TMP_Text highscoredisplaytext;

    // Start is called before the first frame update
    void Start()
    {
        highScore();
    }


    public void highScore()
    {
        highscoredisplaytext.text = "" + PlayerPrefs.GetInt("highScoreText").ToString();
    }
}
