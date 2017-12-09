using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {
    private int nextUpdate = 1;
    public int startLives = 3;
    public int score = 0;
	public int gameWinScore = 400;
    public int scorePerSecond = 1;
    public float timer;
	public GameObject gameOverScene;
	public GameObject gameWinScene;
	public Text scoreText;
    public Text livesText;
    public Text timerText;
    public bool addScore;
    public Vector3 respawnLocation = new Vector3(47.3f, 9.571f, -48.7f);
    public Vector3 respawnVelocity = new Vector3(0, 0, 0);
    public Vector3 respawnAngularVelocity = new Vector3(0, 0, 0);
    public int startTime = 20;
    public int maxAddTime = 5;
    public int medAddTime = 11;
    public int minAddTime = 17;
    public int maxTime = 12;
    public int minTime = 5;
    public int checkPoints = 10;

    private void Start()
    {
        timer = startTime;
    }
    
    void Update () {
        if (timer <= 0)
        {
            GameOver();
        }
        if (Time.time >= nextUpdate && addScore)
        {
            AddPoints(scorePerSecond);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
        }
        timer -= Time.deltaTime;
        timerText.text = "Timer: " + timer.ToString("0");

        if (timer < 10)
        {
            timerText.color = new Color(1f, 0f, 0f);
        }
        else
        {
            timerText.color = new Color(1f, 1f, 1f);
        }
    }

    internal void AddPoints(int addScore)
    {
        score += addScore;
		scoreText.text = "Score: " + score;
		if(score == gameWinScore) {
			GameWin();
		}
    }

    internal void AddTime(int t)
    {
        timer += t;
    }

    internal void GameOver()
    {
		//put game over w/ lose sound here (get rid of all other sounds)
        gameOverScene.SetActive(true);
    }

	internal void GameWin() {
		//put applause w/ happy noise underneath (get rid of all other sounds)
		gameWinScene.SetActive(true);
	}
}