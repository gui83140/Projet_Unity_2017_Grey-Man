using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    bool star1pickup;
    bool star2pickup;

    public AudioSource[] sounds;

    public AudioSource noise1;
    public AudioSource noise2;




    static float lifes;

    public GameObject musique;

    public GameObject player;

    public GameObject playerpos;

    public GameObject life1;

    public GameObject life2;

    public GameObject life3;

    public GameObject life4;

    public GameObject Level1completed;

    public GameObject Level2completed;

    public GameObject Defaite;

    public static float stars;

     


    Vector3 testpos;

	void Start () {

        star1pickup = false;
        star2pickup = false;

        noise1 = sounds[0];
        noise2 = sounds[1];



        stars = 0;
        testpos = playerpos.transform.position;
        lifes = 4;
        GameObject currentplayer = Instantiate(player);
        currentplayer.transform.position = testpos;


    }

    private void Update()
    {
        if ( stars == 1)
        {

            if (!star1pickup)
            {

                noise2.Play();
                musique.SetActive(false);
                Level1completed.SetActive(true);
                star1pickup = true;
            }
        }

        if (stars == 2)
        {
            if (!star2pickup)
            {
                noise2.Play();
                musique.SetActive(false);
                Level2completed.SetActive(true);
                star2pickup = true;
            }
        }

    }




    public void DEATH()
    {
        //noise1.Play();
        if (lifes == 1)
        {
            noise1.Play();
            musique.SetActive(false);
            Destroy(life4);
            scriptmasterephemere.ponton = true;
            Defaite.SetActive(true);

        }
        Invoke("Restart",2f);


    }

    public void Restart() {

        lifes = lifes - 1;

        
        GameObject currentplayer = Instantiate(player);
        currentplayer.transform.position = testpos;

        if (lifes == 3)
        {

            
            Destroy(life1);
            scriptmasterephemere.ponton = true;
        }

        if (lifes == 2)
        {
            
            Destroy(life2);
            scriptmasterephemere.ponton = true; 
        }

        if (lifes == 1)
        {
            
            Destroy(life3);
            scriptmasterephemere.ponton = true;
        }

        if (lifes == 0)
        {
            Destroy(life4);
            scriptmasterephemere.ponton = true;
            Defaite.SetActive(true);

        }

        //SceneManager.LoadScene("niveau1");

    }

   /* public void ()
    {
        
        
        
        /*testpos = playerpos.transform.position;
        GameObject currentplayer = Instantiate(player);
        currentplayer.transform.position = testpos;
        Debug.Log("cul");
        
    }*/

}
