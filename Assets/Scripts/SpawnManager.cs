using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    float spawnPosX = 20;
    float spawnPosZ = 20;

    float startDelay = 2;
    float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[animalIndex];

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);

        Instantiate(animal, spawnPosition, animal.transform.rotation);
    }
}
