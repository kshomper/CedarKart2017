using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    Animator anim;
    bool isPaused = false;
    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();
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

    void Pause()
    {
        Time.timeScale = 0.0f;
        Cursor.visible = true;
        isPaused = true;
        OpenPauseMenu();
    }

    void UnPause()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = false;
        isPaused = false;
        ClosePauseMenu();
    }

    internal void OpenPauseMenu()
    {
        anim.SetTrigger("Open");
    }

    internal void ClosePauseMenu()
    {
        anim.SetTrigger("Close");
    }
}
