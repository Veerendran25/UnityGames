using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goalscorepoint : MonoBehaviour
{
    private float Player2=0;
    private float Player1=0;
    public  Text goal1;
    public Text goal2;
    public Text winner;

    public GameObject ball;
    private bool levelCompleted=false;
     
    public void update()
    {
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("goalline2") )
        {
            Player1++;
            goal1.text="Player1="+Player1;
        }
        
     if(collision.gameObject.CompareTag("goalline"))
        {
            Player2++;
            goal2.text="Player2="+Player2;
        }
     if(goal1.text=="Player1=5")
     {   
        winner.text="PLAYER1 WON";
        levelCompleted=true;
        Invoke("CompleteLevel",2f);
    }
    if(goal2.text=="Player2=5")
    {
        winner.text="PLAYER2 WON";
        levelCompleted=true;
        Invoke("CompleteLevel",2f);
    }
    }
    private void CompleteLevel()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

}