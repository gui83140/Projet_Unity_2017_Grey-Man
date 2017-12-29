using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void play()
    {
        SceneManager.LoadScene("niveau1");

    }

    public void Quit()
    {
        Application.Quit();

        Debug.Log("raldefin");

    }


}
