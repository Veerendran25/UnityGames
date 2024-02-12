using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{   
    public GameObject ball;
    public Transform ballPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
   public void OnCollisionEnter(Collision collision)
   {
    if(collision.gameObject.name=="terrain")
    {
        transform.position = ballPos.position;
    }
   }
}
