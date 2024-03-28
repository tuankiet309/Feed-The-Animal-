using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float xRange = 16;
    public float zRange = 30;
    public float spawnTime = 1f;
    private float spawnTimeCounter;
    public float delayTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimeCounter -= Time.deltaTime;
        if(spawnTimeCounter < 0)
        {   int i = Random.Range(0, animalPrefab.Length);
            Vector3 randomPos = new Vector3(Random.Range(-xRange, xRange), 0, zRange);
            Instantiate(animalPrefab[i], randomPos, animalPrefab[i].transform.rotation);
            float randomTimer = Random.Range(spawnTime, spawnTime+delayTime);
            spawnTimeCounter = randomTimer;         
        }
    }
}
