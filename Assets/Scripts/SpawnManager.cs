using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject dynamitePrefab;
    public bool stopSpawning = false;
    public float spawnTime = 1.0f;
    public float spawnDelay = 1.0f;
    private float spawnRange = 10.0f;


    // Generate spawn position
    void Start()
    {
        Instantiate(dynamitePrefab, GenerateSpawnPosition(), dynamitePrefab.transform.rotation);
    }

    // Generate a random spawn position on X axis
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 40, spawnPosZ);

        return randomPos;
    }
}