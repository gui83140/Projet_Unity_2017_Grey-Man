using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptmasterephemere : MonoBehaviour {

    public static bool ponton;

    void Start () {
        ponton = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (ponton) {



        foreach (Transform child in transform)
                child.gameObject.SetActive(true);


            ponton = false;
        }
		
	}
}
