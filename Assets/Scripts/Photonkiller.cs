using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photonkiller : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Photon"))
            
            Destroy(transform.gameObject);
    }
    

 
}