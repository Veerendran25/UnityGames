using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
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
        if(collision.gameObject.name=="goalline")
        {
          transform.position = ballPos.position;
    
        }
   }
}
