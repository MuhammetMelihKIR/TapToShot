using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class scoreManager : MonoBehaviour
{
    [SerializeField] public GameObject ball;
    [SerializeField] public  TMP_Text scoreText;
   
    public TMP_Text gameovertextText;
    public static bool sayýoldu;
    public static  int scoreValue;
    public AudioClip rimclip;
    public AudioClip scoreSound;
    private bool alt=false; 
    
    
      

    void Start()
    {
       
            

    }
    public void Update()
    {
        
        gameovertextText.text = scoreText.text;
        scoreText.text = "" + scoreValue.ToString();
        if (scoreValue > PlayerPrefs.GetInt("highScoreText"))
            PlayerPrefs.SetInt("highScoreText", scoreValue);
    }
    public void OnTriggerExit2D(Collider2D score_trigger)
    {


        if (score_trigger.tag == "trigger" && alt == true)
        {
            
            scoreValue += 1;
            scoreText.text = " " + scoreValue;
            sayýoldu = true;
            alt = false;
            if (musicButton.music == true)
            {
                AudioSource.PlayClipAtPoint(scoreSound, Camera.main.transform.position);
            }



        }
        else if (score_trigger.tag == "trigger2" && alt == true)
        {
            
            scoreValue += 1;
            scoreText.text = " " + scoreValue;
            sayýoldu = true;
            if (musicButton.music == true)
            {
                AudioSource.PlayClipAtPoint(scoreSound, Camera.main.transform.position);
            }


        }
        if (score_trigger.tag == "alttrigger")
        {
            alt = true;
        }

    }
    public void OnTriggerEnter2D(Collider2D altfile)
    {
       if(altfile.tag == "altfile")
        {
            if (musicButton.music == true)
            {
                AudioSource.PlayClipAtPoint(rimclip, Camera.main.transform.position);
            }
        }


    }


}
