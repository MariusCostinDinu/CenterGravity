using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;
    readonly bool canSpawn = true;
    readonly float spawnTime = 1.0f;
    int caseNr;
    float rngX, rngY;
    void Start()
    {
        StartCoroutine(AsteroidSpawnTimer());
    }
    IEnumerator AsteroidSpawnTimer()
    {
        while (canSpawn) {
            CreateAsteroid();
        yield return new WaitForSeconds(spawnTime);
      }
    }

    void CreateAsteroid()
    {
        caseNr = Random.Range(1, 4);
        switch(caseNr)
        {
            case 1:
                rngX = Random.Range(-36,36);
                rngY = Random.Range(20, 23);
                break;
            case 2:
                rngX = Random.Range(44, 47);
                rngY = Random.Range(-13, 13);
                break;
            case 3:
                rngX = Random.Range(-36, 36);
                rngY = Random.Range(-21, -19);
                break;
            case 4:
                rngX = Random.Range(-45, -42);
                rngY = Random.Range(-13, 13);
                break;
        }
        Instantiate(asteroid,new Vector3(rngX,rngY,0), Quaternion.identity);
    }
}
