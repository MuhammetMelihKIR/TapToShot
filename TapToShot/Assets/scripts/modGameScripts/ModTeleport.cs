using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModTeleport : MonoBehaviour
{
   
    public  GameObject teleport1;
    public  GameObject teleport2;
    public GameObject teleport3;
    public GameObject teleport4;
    
    
   
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
       
        
            teleport1.SetActive(true);
            teleport2.SetActive(true);
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "teleport1" )
        {

            gameObject.transform.position = new Vector3(teleport3.transform.position.x, gameObject.transform.position.y);
            
            
        }
        if (collision.tag == "teleport2")
        {


            gameObject.transform.position = new Vector3(teleport4.transform.position.x, gameObject.transform.position.y);

            
        }

    }
   

   }
