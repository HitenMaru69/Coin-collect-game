using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coincollect : MonoBehaviour
{
    public Text score;

    public int scorenum;
    int num = 0;

    public GameObject win;

    float currenttime = 0f;
    public float starttime =60f;

    public Text time;
    
    
    public GameObject Nextpanal;

    //Sound

    public AudioSource Coinsound;
   

   
    // Start is called before the first frame update
    void Start()
    {
        
     
        score.text = "Coin:" + scorenum;

        currenttime = starttime;

        Coinsound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        currenttime -= 1 * Time.deltaTime;
        time.text = currenttime.ToString("0");

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            scorenum -= 1;
            Coinsound.Play();
            Destroy(collision.gameObject);
            score.text = "Coin:" + scorenum;

            if (scorenum==num)
            {
                Destroy(time);

               
                Nextpanal.SetActive(true);
                

            }

            
        }

    }
}
