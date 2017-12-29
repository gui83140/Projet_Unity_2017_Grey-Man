using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blobscript : MonoBehaviour {

    float posinit;
    public float range;
    public float speed;
    Rigidbody rb;
    bool retro;




    void Start()
    {
        retro = false;
        posinit = transform.position.x;
        rb = GetComponent<Rigidbody>();
    }
   
    void FixedUpdate()
    {

        //transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);

        rb.velocity = new Vector3(speed, 0, 0);


        if (retro)
        {
            speed = -1;
        }

        else
        {
            speed = 1;
        }

        if (transform.position.x >= posinit + range)
        {
            retro = true;
            transform.Rotate(0,180,0);

        }

        if (transform.position.x <= posinit - range)
        {
            retro = false;
            transform.Rotate(0, 180, 0);
        }


    }
}
