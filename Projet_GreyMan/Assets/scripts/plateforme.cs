using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateforme : MonoBehaviour {

    float posinit;
    public float range;
    public float speed;
    public static float speedo;
    Rigidbody rb;
    bool retro;

    


	void Start () {
     retro = false;
     posinit = transform.position.x;
     rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        //transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
        
        speedo = speed;
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

        }

        if (transform.position.x <= posinit - range)
        {
            retro = false;

        }


    }

    private void Update()
    {
       
    }
}
