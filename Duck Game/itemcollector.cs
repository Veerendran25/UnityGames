using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemcollector : MonoBehaviour
{
    private int Apples=0;
    public Text items;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("powerups"))
    {
        Destroy(collision.gameObject);
        Apples++;
        items.text="Apples:"+ Apples;
    }
  }
}
