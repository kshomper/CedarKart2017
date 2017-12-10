using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartExit : MonoBehaviour {
    public PauseGame pg;

    public void RestartGame()
    {
        pg.UnPause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
    public void ExitToMenu()
    {
        pg.UnPause();
        Cursor.visible = true;
        SceneManager.LoadScene("MainMenu");
    }
}
