using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    private int nextUpdate = 1;
    public int score = 0;
    public int scorePerSecond = 10;
    public float TimeBetween = 45f;
    public float timer;
    public bool CountTimerDown = true;

    private bool addScore;

    private void Start()
    {
        addScore = true;
        timer = TimeBetween;
    }
    
    void Update () {
        if (timer < 0)
        {
            GameOver();
        }
        if (Time.time >= nextUpdate && addScore)
        {
            AddPoints(scorePerSecond);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
        }
        timer -= Time.deltaTime;

    }

    internal void AddPoints(int addScore)
    {
        score += addScore;
    }

    internal void ResetTimer()
    {
        if (CountTimerDown)
        {
            if(TimeBetween > 10f)
            {
                TimeBetween = TimeBetween - 5f;
            }
            timer = TimeBetween;
        }
    }

    internal void GameOver()
    {
        throw new NotImplementedException();
    }
}
