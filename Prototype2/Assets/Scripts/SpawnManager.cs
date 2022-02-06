/*
 * Josh McGrew
 * Assignment 3: Prototype 2
 * spawn manager
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //set this array of references in the inspector
    public GameObject[] prefabsToSpawn;

    //variables for spawn position
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    private void Start()
    {
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
        StartCoroutine(SpawnRPCoroutine());

    }

    IEnumerator SpawnRPCoroutine()
    {
        //add 3s delay before first spawning object
        yield return new WaitForSeconds(3f);

        while (true)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(1.4f,2.5f);

            yield return new WaitForSeconds(randomDelay);
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPrefab();
        }
    }

    void SpawnRandomPrefab()
    {
        //random animal
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate a random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
