using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour
{
    public Transform [] spawnPoints;
    public GameObject objectToSpawn;
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Drop"))
        {
        Destroy(col.gameObject);
        if (spawnPoints.Length == 0 || objectToSpawn == null)
        {
            Debug.LogError("Spawn points array or object to spawn not set up correctly!");
            return;
        }
        SpawnObjectAtRandomPoint();
    }

    void SpawnObjectAtRandomPoint()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform randomSpawnPoint = spawnPoints[randomIndex];

        Instantiate(objectToSpawn, randomSpawnPoint.position, randomSpawnPoint.rotation);
    }
        }
    }
