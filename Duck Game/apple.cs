using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-6f)
        {
            Destroy(gameObject);
        }
    }
}
