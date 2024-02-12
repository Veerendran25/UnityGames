using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{public static bool isgamepaused=false;
public  GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
       {
        if(isgamepaused)
        {
            resume();
        }
        else{
            pause();
        }
       }       
    }
    public void resume()
    {
          pauseMenuUI.SetActive(false);
          Time.timeScale = 1.0f;
          isgamepaused =false;
    }
    public void pause()
    {
           pauseMenuUI.SetActive(true);
           Time.timeScale = 0f;
           isgamepaused=true;
    }
    public void load()
    {
        SceneManager.LoadScene("menu");
    }
    public void quit()
    {
        Application.Quit();
    }
}
