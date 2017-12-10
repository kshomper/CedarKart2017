using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartExit : MonoBehaviour {
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
