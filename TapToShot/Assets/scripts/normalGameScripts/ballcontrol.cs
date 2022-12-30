using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public GameObject ball;
     
    public Rigidbody2D rigid;
    public float forceUp;
    public float hareket;
    public float hareket2;
    public float ballspeed = 0.5f;
    public bool right;
    public bool left;
    public AudioClip touchSound;

    
    public void Start()
    {
        rigid = ball.GetComponent<Rigidbody2D>();
        right = true;
        left = false;
        scoreManager.scoreValue = 0;
        
    }
    public void OnMouseDown()
    {
        

        if (spawnManager.destroy == true )
        {

            rigid.velocity = new Vector2(hareket, forceUp);
            right = true;
            left = false;
            if (musicButton.music == true)
            {
                AudioSource.PlayClipAtPoint(touchSound, Camera.main.transform.position);
            }
            
            
           
                
        }
        else if(spawnManager.destroy == false)
        {
            rigid.velocity = new Vector2(hareket2, forceUp);
            left = true;
            right = false;
            if (musicButton.music == true)
            {
                AudioSource.PlayClipAtPoint(touchSound, Camera.main.transform.position);
            }


        }
        
    }

}
