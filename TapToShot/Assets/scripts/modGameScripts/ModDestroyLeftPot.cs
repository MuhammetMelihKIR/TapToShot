using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModDestroyLeftPot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ModSpawnManager.destroy)
        {
            ModPlayerBar.bar = 0;
            Destroy(gameObject,0.2f);
        }
    }
}
