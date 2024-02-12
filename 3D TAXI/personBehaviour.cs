using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class personBehaviour : MonoBehaviour
{
    private int person=0;
    public Text number;
    public Transform[] dropPoints;
    public GameObject dropZone;
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("person"))
        {
        Destroy(col.gameObject);
        person++;
        number.text=":"+person;
        SpawnDropZone();
        }
    void SpawnDropZone()
    {
        int randomIndex = Random.Range(0, dropPoints.Length);
        Transform randomDropPoint = dropPoints[randomIndex];

        Instantiate(dropZone, randomDropPoint.position, randomDropPoint.rotation);
    }
        }
    }