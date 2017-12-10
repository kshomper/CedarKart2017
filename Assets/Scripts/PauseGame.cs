using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public Canvas PauseMenu;
    bool isPaused = false;
    // Use this for initialization
    void Start() {
        PauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyUp("escape"))
        {
            if(isPaused)
            {
                UnPause();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        OpenPauseMenu();
        Time.timeScale = 0.0f;
        Cursor.visible = true;
        isPaused = true;
    }

    public void UnPause()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = false;
        isPaused = false;
        ClosePauseMenu();
    }

    internal void OpenPauseMenu()
    {
        PauseMenu.gameObject.SetActive(true);
    }

    internal void ClosePauseMenu()
    {
        PauseMenu.gameObject.SetActive(false);
    }
}
