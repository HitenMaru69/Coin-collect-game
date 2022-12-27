using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    GameObject player;
    public float waittime;

    public GameObject panal;

  
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroyplayer(waittime));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Destroyplayer(float waittime)
    {

        player = GameObject.FindWithTag("Player");
        yield return new WaitForSeconds(waittime);

        ;
        Destroy(player.gameObject);
        panal.SetActive(true);
       
    }



}
