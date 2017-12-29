using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insectplatformcontroller : MonoBehaviour
{

    // Use this for initialization

    private Rigidbody rb;
    private Animator anim;
    Vector3 mvt;
    public float chemin;
    float positionINIT;
    float direction;
    public float speed;
    float turntime;
    //float timerotation;

    void Start()
    {
        direction = 1;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        positionINIT = transform.position.x;
       // timerotation = 180 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        //timerotation = 180 * Time.deltaTime;

        // anim.SetBool("swip", false);
        turntime = turntime +1;
        if (((Math.Abs(positionINIT)) + (Math.Abs(transform.position.x)) >= positionINIT + chemin) && turntime>10 && direction == 1)
        {

            turntime = 0;
            direction = -1;
           // anim.SetBool("swip", true);
             transform.Rotate(0, 180, 0);
            Debug.Log("oui");
        //    anim.SetBool("swip", true);
            /*  anim.SetBool("swip", true);
              if (direction == 1)
              {
                  turntime = turntime + 1;
                  direction = -1;
                  transform.Rotate(0, 180 , 0) ;
                  Debug.Log("oui");
              }

              else
              {
                  direction = 1;
                  transform.Rotate(0, 180, 0);
                  Debug.Log("non");
              }

      */

        }

        if (((Math.Abs(positionINIT)) + (Math.Abs(transform.position.x)) >= positionINIT + chemin) && turntime > 10 && direction == -1)
        {
            turntime = 0;
            direction = 1;
            //transform.Rotate(0, 180, 0);
            transform.Rotate(0, 180, 0);
            Debug.Log("non");
           // anim.SetBool("swip", true);


        }

        //Time.deltaTime *


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3( speed*direction, 0f,0f);

        
        //anim.SetFloat("mvt", rb.velocity.y);
    }
}



