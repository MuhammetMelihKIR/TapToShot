using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLeftPot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnManager.destroy)
        {
            playerBar.bar = 0;
            Destroy(gameObject,0.2f);
        }
    }
}
