using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoints : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform[] dropPoints;
    public GameObject dropZone;
    public GameObject objectToSpawn;

    void Start()
    {
        if (spawnPoints.Length == 0 || objectToSpawn == null)
        {
            Debug.LogError("Spawn points array or object to spawn not set up correctly!");
            return;
        }
        SpawnObjectAtRandomPoint();
        SpawnDropZone();
    }

    void SpawnObjectAtRandomPoint()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform randomSpawnPoint = spawnPoints[randomIndex];

        Instantiate(objectToSpawn, randomSpawnPoint.position, randomSpawnPoint.rotation);
    }

    void SpawnDropZone()
    {
        int randomIndex = Random.Range(0, dropPoints.Length);
        Transform randomDropPoint = dropPoints[randomIndex];

        Instantiate(dropZone, randomDropPoint.position, randomDropPoint.rotation);
    }

}
