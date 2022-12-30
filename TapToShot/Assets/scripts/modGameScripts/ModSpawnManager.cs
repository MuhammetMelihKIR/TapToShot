using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ModSpawnManager : MonoBehaviour
{
    public GameObject rightpota;
    public GameObject leftpota;
    public float leftX;
    public float rightX;
    public float upY;
    public float downY;
    public bool rightin;
    public bool leftin;
    public static bool destroy;
    // Start is called before the first frame update
    void Start()
    {
        destroy = true; 
        leftin = true;
        rightin = false;
    }

    
    void Update()
    {
        if (ModScoreManager.SRMsayýoldu == true && leftin==false)
        {
            ModScoreManager.SRMsayýoldu=false;
            leftin = true;
            rightin = false;
            Vector2 randomSpawnPosition= new Vector2(rightX,Random.Range(upY,downY));
            Instantiate(rightpota,randomSpawnPosition,Quaternion.identity);
            destroy = true;


        }
       
        if (ModScoreManager.SRMsayýoldu == true && rightin==false )
        {
            ModScoreManager.SRMsayýoldu= false;
            rightin = true;
            leftin = false;
            Vector2 randomSpawnPosition = new Vector2(leftX, Random.Range(upY, downY));
            Instantiate(leftpota, randomSpawnPosition, Quaternion.identity);
            destroy =false;
        }
    }
}
