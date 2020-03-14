using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    public float aSpeed = 1.0f;
    void Start()
    {
        float rng = UnityEngine.Random.Range(0.5f,1.5f);
        transform.localScale = new Vector3 (rng, rng, rng);

    }

    // Update is called once per frame
    void Update()
    {
       
        MoveAsteroidToPlayer();
    }

    void MoveAsteroidToPlayer()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3 (0,0,0), aSpeed* Time.deltaTime);   // 000 midle of the screen
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Photon"))
            Destroy(collision.gameObject);

        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene("MainLevel");
    }

   

}
