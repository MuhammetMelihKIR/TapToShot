using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyRightPot : MonoBehaviour
{

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawnManager.destroy)
        {
            playerBar.bar = 0;
            Destroy(gameObject, 0.2f);
        }
    }
}
