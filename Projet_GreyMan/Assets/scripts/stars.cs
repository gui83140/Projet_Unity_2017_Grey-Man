using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour {

    // Use this for initialization


    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision theCollision)
    {
        
        
       if ( (theCollision.gameObject.tag == "Player"))
        {


            GameManager.stars = GameManager.stars + 1;
            Destroy(gameObject);
            //GetComponent<rayman_controller>().freeza();
            //Debug.Log(GameManager.stars);
            //rb.detectCollisions = false;
            //rb.constraints = RigidbodyConstraints.FreezePosition;
            Debug.Log(GameManager.stars);
            
        } 
            
                
    }





    //if ((theCollision.gameObject.tag == "Plateforme"))
    // Update is called once per frame
    void Update () {
        
    }
}
