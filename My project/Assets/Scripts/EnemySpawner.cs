using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float timeToSpawn;
    private float spawnCounter;

    public Transform minSpawn, maxSpawn;

    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCounter -= Time.deltaTime;
        if (spawnCounter <= 0) 
        {
            spawnCounter = timeToSpawn;

            //Instantiate(enemyToSpawn, transform.position ,transform.rotation);

            Instantiate(enemyToSpawn, SelectSpawnPoint(), transform.rotation);
        }
    }

    public Vector3 SelectSpawnPoint() 
    {
        Vector3 spawnPoint = Vector3.zero;
        bool spawnVerticalEdge = Random.Range(0f, 1f) > .5f; 

        if (spawnVerticalEdge)
        {

        }

        return spawnPoint;
    }
}
