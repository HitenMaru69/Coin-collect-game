using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Level1");
        
    }
    
    public void Quit()
    {
        Application.Quit();

    }


    public void RepetLevel()
    {
        FindObjectOfType<Gamemanager>().Currentlevel();
    }

    public void SmallQuit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AnotherLevel()
    {
        FindObjectOfType<Gamemanager>().Nextlevel();
    }

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
  
}
