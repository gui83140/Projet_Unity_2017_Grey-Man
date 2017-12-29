using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piquescripts : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision theCollision)
    {
        

        if (theCollision.gameObject.tag == "Player")
        {
            Debug.Log("biture");
            //GetComponent<AudioSource>().Play();

        }
    }
}