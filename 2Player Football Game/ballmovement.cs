using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{   
    public float moveSpeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void OnTriggerEnter(Collider other)
  {
    if(other.tag == "Player")
    {
      rb.velocity= new Vector3(moveSpeed,rb.velocity.y,rb.velocity.z);
    }
    if(other.tag == "firstplayer")
    {
      rb.velocity= new Vector3(moveSpeed,rb.velocity.y,rb.velocity.z);
    }
  }
}
