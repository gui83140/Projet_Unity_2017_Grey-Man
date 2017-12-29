using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class cubedestuctible : MonoBehaviour {


    public GameObject particule;

    public AudioClip  boom;

     public AudioSource audios;

    
    //public static bool ponton;

    //bool pontonrepeted;


    void Start () {
        //ponton = false;
        audios.clip = boom;

    }
	
	// Update is called once per frame
	void Update () {

       /* if (ponton)
        {
            Debug.Log(ponton);
            gameObject.SetActive(false);
            ponton = false;
            
        }
        */
       



    }


    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Player"  )
        {


            audios.Play();
            GameObject currentparticule = Instantiate(particule);
            currentparticule.transform.position = transform.position;
            //Destroy(gameObject,0.3f);
            //gameObject.SetActive(false);
            Invoke("desactivate",0.3f);
            

        }



    }

    void desactivate()
    {
        gameObject.SetActive(false);
    }
}
