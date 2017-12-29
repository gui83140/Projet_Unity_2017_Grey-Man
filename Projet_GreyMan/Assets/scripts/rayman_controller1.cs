using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayman_controller1 : MonoBehaviour {


    

    float X;

    public float speed;

    public float jumpforce;

    Vector3 movement;

    
    private Rigidbody rb;
    private Animator anim;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
   

        



        void FixedUpdate() {
        anim.SetFloat("velocityY", rb.velocity.y);
        X = Input.GetAxis("Horizontal");
        movement = new Vector3(X*speed, rb.velocity.y, 0);
        rb.velocity = movement;
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0f, jumpforce, 0f);
        }


        //Movement();
        //Jump();  

        }

   /* void Movement()
    {
        X = Input.GetAxis("Horizontal");
        movement = new Vector3(X, 0, 0);
        rb.AddForce(movement);

    }

    void Jump()
    {
        if (Input.GetButton("Jump"))
        {


            rb.AddForce(0f, jumpforce, 0f);
        }
    }*/

    }