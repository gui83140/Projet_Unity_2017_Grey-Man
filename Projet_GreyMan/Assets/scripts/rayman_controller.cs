using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayman_controller : MonoBehaviour
{

    float mvtplat;
    bool plated;

    public static bool freezecamera;
    bool mort;
    bool freeze;
    int saut;

    bool left;
    float X;
    float Y;
    public float speed;

    public float jumpforce = 1;

    Vector3 movement;

    private Rigidbody rb;
    private Animator anim;
    public float fallmultiplier = 2.5f;
    public float lowjump = 2f;

    public AudioSource[] sounds;

    public AudioSource noise1;
    public AudioSource noise2;





    void Start()
    {
        freezecamera = false;
        saut = 0;

        left = false;

        //sounds = GetComponents<AudioSource>();

        noise1 = sounds[0];
        noise2 = sounds[1];



        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();




        //AudioClip.Play(listeson[0]);
        //AudioSource audio = GetComponent<AudioSource>();

        anim.SetBool("move", false);


    }



    private void Update()
    {
        mvtplat = plateforme.speedo;




        if (X < 0 && freeze == false)
        {

            anim.SetBool("move", true);
            if (!left && freeze == false)
            {
                left = true;

                transform.Rotate(0, 180, 0);

            }

        }


        if (X > 0 && freeze == false)
        {
            anim.SetBool("move", true);
            if (left && freeze == false)
            {

                left = false;
                transform.Rotate(0, 180, 0);


            }
        }

        if (Mathf.Approximately(X, 0))
        {
            anim.SetBool("move", false);

        }




        if (mort)
        {

            freezecamera = true;

            rb.velocity = new Vector3(0, 5, 0);


            anim.SetBool("mort", true);
            rb.mass = 30;
            rb.constraints = RigidbodyConstraints.FreezePositionX;
            transform.Rotate(0, 90, 0);
            freeze = true;
            mort = false;
            rb.detectCollisions = false;

            FindObjectOfType<GameManager>().DEATH();

            Destroy(gameObject, 2f);



        }

    }




    void FixedUpdate()
    {
        if (mort == false)
        {
            X = Input.GetAxis("Horizontal");
            if (plated)
            {


                movement = new Vector3(X * speed + mvtplat, rb.velocity.y, 0);
                rb.velocity = movement;
            }

            if (!plated)
            {


                movement = new Vector3(X * speed, rb.velocity.y, 0);
                rb.velocity = movement;

            }





            if (Input.GetButton("Jump") && saut < 1)
            {


                noise1.Play();

                //rb.velocity = new Vector3(rb.velocity.x, jumpforce, 0);

                //GetComponent<AudioSource>().Play();
                rb.velocity = new Vector3(rb.velocity.x, jumpforce, rb.velocity.z);
                anim.SetBool("saut", true);

                saut += 1;






            }

            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (fallmultiplier - 1) * Time.deltaTime;

            }


        }


    }

    void initsaut()
    {

        saut = 0;
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if ((theCollision.gameObject.tag == "SOL") || (theCollision.gameObject.tag == "sol2"))
        {


            anim.SetBool("saut", false);
            anim.SetBool("doublesaut", false);
            saut = 0;
        }

        if ((theCollision.gameObject.tag == "Plateforme"))
        {

            plated = true;
            anim.SetBool("saut", false);
            anim.SetBool("doublesaut", false);
            saut = 0;

        }

        if (theCollision.gameObject.tag == "ennemis")
        {
            mort = true;

            noise2.Play();

        }


        if (theCollision.gameObject.tag == "etoile")
        {
            freeza();

        }


    }
    void OnCollisionExit(Collision theCollision)
    {
        if ((theCollision.gameObject.tag == "Plateforme"))
        {

            plated = false;



        }
    }

    //void OnTriggerEnter(Collider other)

     void freeza (){

        Debug.Log("arthour");
        rb.detectCollisions = false;
        rb.constraints = RigidbodyConstraints.FreezePosition;
        //rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
}