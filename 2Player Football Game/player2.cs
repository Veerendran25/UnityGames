using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float speed;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode jump;
    private Rigidbody rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
             rb.velocity= new Vector3(speed,rb.velocity.y,rb.velocity.z);
        }else if(Input.GetKey(left))
        {
            rb.velocity= new Vector3(-speed,rb.velocity.y,rb.velocity.z);
        }
        else{
            rb.velocity= new Vector3(0,rb.velocity.y,rb.velocity.z);
        }
    if(Input.GetKey(up))
    {
        rb.velocity= new Vector3(rb.velocity.x,rb.velocity.y,-speed);
    }
    else if(Input.GetKey(down))
    {
        rb.velocity= new Vector3(rb.velocity.x,rb.velocity.y,speed);
    }else{
        rb.velocity= new Vector3(rb.velocity.x,rb.velocity.y,0);
    }

    if (Input.GetKeyDown(jump))
    {
        rb.velocity= new Vector3(rb.velocity.x,jumpForce,rb.velocity.z);

    }else
    {
        rb.velocity= new Vector3(rb.velocity.x,0,rb.velocity.z);
    }
    }
    
}
