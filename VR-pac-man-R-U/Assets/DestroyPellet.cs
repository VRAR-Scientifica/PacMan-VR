using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPellet:controller {
    

    public AudioClip pelletSound;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            score += 10;
        }

    }

  

}
