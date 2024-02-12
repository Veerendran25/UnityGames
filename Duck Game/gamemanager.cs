using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject gameObject;
    public float max;
    public Transform spawnpoint;
    public float spawnrate;
    bool gamestarted =false;





    void Update()
    {
      if(Input.GetMouseButtonDown(0)&& !gamestarted)
      {
        start();
        gamestarted=true;
      }

    }

    private void start()
    {
        InvokeRepeating("Spawn",2f,spawnrate);
    }
    // Start is called before the first frame update
    void Spawn()
    {
        Vector3 spawnPos =spawnpoint.position;
        spawnPos.x=Random.Range(-max,max);
        Instantiate(gameObject,spawnPos,Quaternion.identity);
    }

    // Update is called once per frame
    
}
