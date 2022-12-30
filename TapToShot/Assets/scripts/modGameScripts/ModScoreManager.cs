using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ModScoreManager : MonoBehaviour
{
    [SerializeField] public GameObject ball;
    [SerializeField] public  TMP_Text SRMscoreText;
   
    public TMP_Text SRMgameovertextText;
    public static bool SRMsayýoldu;
    public static  int SRMscoreValue;
    public AudioClip rimclip;
    public AudioClip scoreSound;
    private bool alt=false; 
    
    
      

    void Start()
    {
       
            
 
    }
    public void Update()
    {
        
        SRMgameovertextText.text = SRMscoreText.text;
        SRMscoreText.text = "" + SRMscoreValue.ToString();
        if (SRMscoreValue > PlayerPrefs.GetInt("SRMHighScoreText"))
            PlayerPrefs.SetInt("SRMHighScoreText", SRMscoreValue);
    }
    public void OnTriggerExit2D(Collider2D score_trigger)
    {


        if (score_trigger.tag == "trigger" && alt == true)
        {
            
            SRMscoreValue += 1;
            SRMscoreText.text = " " + SRMscoreValue;
            SRMsayýoldu = true;
            alt = false;
            if (ModMusicButton.music == true)
            {
                AudioSource.PlayClipAtPoint(scoreSound, Camera.main.transform.position);
            }
       



        }
        else if (score_trigger.tag == "trigger2" && alt == true)
        {
            
            SRMscoreValue += 1;
            SRMscoreText.text = " " + SRMscoreValue;
            SRMsayýoldu = true;
            if (ModMusicButton.music == true)
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
            if (ModMusicButton.music == true)
            {
                AudioSource.PlayClipAtPoint(rimclip, Camera.main.transform.position);
            }
        }


    }


}
