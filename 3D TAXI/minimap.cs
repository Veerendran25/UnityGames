using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public Transform player;
    void LateUpdate()
    {
        Vector3 pos= player.position;
        pos.y=transform.position.y;
        transform.position=pos;

        transform.rotation=Quaternion.Euler(90f,player.eulerAngles.y,0f);
    }
}
