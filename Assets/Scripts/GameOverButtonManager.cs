using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtonManager : MonoBehaviour {
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
    public void exitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
