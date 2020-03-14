using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerAsteroid : MonoBehaviour
{
    Score addToScor;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            CallScoreLogicScript();
            Destroy(collision.gameObject);
        }
    }
    
    void CallScoreLogicScript()
    {
        addToScor = GameObject.FindGameObjectWithTag("GUI").GetComponent<Score>();
        addToScor.AddToScoreVOID();
    }

}
