using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{

    public int score = 0;
    public int lives = 3;
    public int scorePerSecond = 10;
    public bool addScore;
    private int nextUpdate = 1;
    private Rigidbody rigidbody;


    private void Start()
    {
        addScore = true;
        rigidbody = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Time.time >= nextUpdate && addScore)
        {
            AddPoints(scorePerSecond);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
        }
    }

    private void AddPoints(int scorePerSecond)
    {
        score += scorePerSecond;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Die();
        }
        else if (other.tag == "Checkpoint")
        {
            AddPoints(1000);
        }
    }

    private void Die()
    {
        lives -= 1;
        
        if(lives <= 0)
        {
            //do the game over action
        }
        this.transform.position = new Vector3(-92.92691f, 7.17f, -71.57132f);
        rigidbody.velocity = new Vector3(0, 0, 0);
        rigidbody.angularVelocity = new Vector3(0, 0, 0);
    }
}
