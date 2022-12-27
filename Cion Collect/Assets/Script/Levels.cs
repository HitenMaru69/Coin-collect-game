using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void Level1()
    {
        Invoke("LoadLevel1", 2f);
    }
    public void Level2()
    {
        Invoke("LoadLevel2", 2f);
    }
    public void Level3()
    {
        Invoke("LoadLevel3", 2f);
    }
    public void Level4()
    {
        Invoke("LoadLevel4", 2f);

    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
    // Level Load classes
   void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    void LoadLevel4()
    {
        SceneManager.LoadScene("Level4");
    }
    
}
