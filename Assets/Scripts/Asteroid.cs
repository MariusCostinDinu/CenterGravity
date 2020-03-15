using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    public GameObject particles;
    public float aSpeed = 1.0f;
    void Start()
    {
        float rng = UnityEngine.Random.Range(0.5f,1.5f);
        transform.localScale = new Vector3 (rng, rng, rng);
    }

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
        {
            SpawnParticle(collision.transform.position);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene("MainLevel");
    }

    void SpawnParticle(Vector2 TempPosition)
    {
        Instantiate(particles, TempPosition, Quaternion.identity);
    }


}
