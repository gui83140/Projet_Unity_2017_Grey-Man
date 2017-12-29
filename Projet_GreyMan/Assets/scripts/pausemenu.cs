using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {

    public static bool Gameispaused = false;

    public GameObject PauseMenuUi;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (Gameispaused)
            {

                Resume();
            }

            else
            {
                Pause();

            }


        }

	}

    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 0f;
        Gameispaused = false;

    }

    void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        Gameispaused = true;

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");

    }
}
