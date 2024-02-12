using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imphenzia_carscript : MonoBehaviour
{
    private float dy,dx;
    public WheelCollider wheelColliderLeftFront;
    public WheelCollider wheelColliderRightFront;
    public WheelCollider wheelColliderLeftBack;
    public WheelCollider wheelColliderRightBack;

    public Transform centerOfMass;
    public Transform WheelLeftFront;
    public Transform WheelRightFront;
    public Transform WheelLeftBack;
    public Transform WheelRightBack;

    public float motorTorque=100f;
    public float maxSteer=20f;
    private Rigidbody  _rigidbody;

    public Transform [] spawnPoints;
    public GameObject objectToSpawn;

    void Start()
    {
        _rigidbody=GetComponent<Rigidbody>();
        _rigidbody.centerOfMass =centerOfMass.localPosition;

          if (spawnPoints.Length == 0 || objectToSpawn == null)
        {
            Debug.LogError("Spawn points array or object to spawn not set up correctly!");
            return;
        }
        SpawnObjectAtRandomPoint();
    }
  public void MoveInput(float input)
  {
    dy=input;
  }
    public void SteerInput(float input)
  {
    dx=input;
  }
    
    void FixedUpdate()
    {
        wheelColliderLeftFront.motorTorque=dy*motorTorque;
        wheelColliderRightFront.motorTorque=dy*motorTorque;
        wheelColliderLeftBack.motorTorque=dy*motorTorque;
        wheelColliderRightBack.motorTorque=dy*motorTorque;
        wheelColliderLeftFront.steerAngle=dx*maxSteer;
        wheelColliderRightFront.steerAngle=dx*maxSteer;
    }
    void Update()
    {
        var pos =Vector3.zero;
        var rot =Quaternion.identity;
        wheelColliderLeftFront.GetWorldPose(out pos ,out rot);
        WheelLeftFront.position=pos;
        WheelLeftFront.rotation=rot;
        wheelColliderRightFront.GetWorldPose(out pos,out rot);
        WheelRightFront.position=pos;
        WheelRightFront.rotation=rot *Quaternion.Euler(0,180,0);
        wheelColliderLeftBack.GetWorldPose(out pos ,out rot);
        WheelLeftBack.position=pos;
        WheelLeftBack.rotation=rot;
        wheelColliderRightBack.GetWorldPose(out pos,out rot);
        WheelRightBack.position=pos;
        WheelRightBack.rotation=rot*Quaternion.Euler(0,180,0);        
    }


void SpawnObjectAtRandomPoint()
{
  int randomIndex=Random.Range(0,spawnPoints.Length);
  Transform randomSpawnPoint= spawnPoints[randomIndex];

  Instantiate(objectToSpawn,randomSpawnPoint.position,randomSpawnPoint.rotation);
}

}