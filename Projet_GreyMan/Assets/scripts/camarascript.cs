using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarascript : MonoBehaviour {

    bool nomvt;
    public GameObject player;
    float X; float Y;

    void Start() {

        
    }

    // Update is called once per frame
    void Update() {

        if (player == null)
        {
            search();

        }

        nomvt = rayman_controller.freezecamera;

        if (nomvt == false)
        {

            X = player.transform.position.x + 4;
            //Y = player.transform.position.y + 2;
            transform.position = new Vector3(X, transform.position.y, transform.position.z);
        }
    }


    void search (){

        player = GameObject.FindGameObjectWithTag("Player");

    }
}
