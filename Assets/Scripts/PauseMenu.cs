using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;

    public GameObject UI;
    public Animator animator;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape) && !(animator.GetBool("isEndGame")))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if(animator.GetBool("isEndGame"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
	}

    public void Resume()
    {
        UI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        UI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("UI main");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
