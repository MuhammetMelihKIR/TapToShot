using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ModSaveScore : MonoBehaviour
{
    [SerializeField] TMP_Text SRMhighscoredisplaytext;

    // Start is called before the first frame update
    void Start()
    {
        highScore();
    }


    public void highScore()
    {
        SRMhighscoredisplaytext.text = "" + PlayerPrefs.GetInt("SRMHighScoreText").ToString();
    }
}
