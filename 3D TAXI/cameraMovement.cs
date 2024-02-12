using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Vector3 offset;
    public Transform target;
    public float translateSpeed;
    public float rotationSpeed;

    private void FixedUpdate()
    {
        Translation();
        rotation();
    } 

    private void Translation()
    {
        var targetPos=target.TransformPoint(offset);
        transform.position=Vector3.Lerp(transform.position,targetPos,translateSpeed*Time.deltaTime);
    }
    private void rotation()
    {
        var direction =target.position-transform.position;
        var rotation=Quaternion.LookRotation(direction,Vector3.up);
        transform.rotation=Quaternion.Lerp(transform.rotation,rotation,rotationSpeed*Time.deltaTime);
    }
}
