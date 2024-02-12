using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{   public float speed; 
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        
        Vector3 PlayerInput= new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        transform.position=transform.position + PlayerInput*speed*Time.deltaTime;
    }
}
