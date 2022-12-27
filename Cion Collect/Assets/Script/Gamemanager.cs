using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool isgameend = false;

    public void Nextlevel()
    {
        if (isgameend == false)
        {
            isgameend = true;
            Invoke("LoadLevel", 1f);
        }

    }

    public void Currentlevel()
    {
        if (isgameend == false)
        {
            isgameend = true;
            Invoke("Restartlevel", 1f);
        }

    }


    void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   
}
