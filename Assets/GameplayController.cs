using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    private Rigidbody CarRigidbody;
    public GameMaster mainController;
    private int lives;
    private bool addScore;
    private Text livesText;

    private void Start()
    {
        lives = mainController.startLives;
        addScore = mainController.addScore;
        livesText = mainController.livesText;
        livesText.text = "Lives: " + lives;
        CarRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Die();
        }
        else if (other.tag == "Checkpoint")
        {
            if(mainController.timer > mainController.maxTime)
            {
                mainController.AddTime(mainController.maxAddTime);
            } else if(mainController.timer < mainController.minTime)
            {
                mainController.AddTime(mainController.minAddTime);
            } else
            {
                mainController.AddTime(mainController.medAddTime);
            }
			if(addScore) {
	            mainController.AddPoints(mainController.checkPoints);
			}
        }
    }

    private void Die()
    {
        lives -= 1;
		livesText.text = "Lives: " + lives;

        if(lives <= 0)
        {
            mainController.GameOver();
        }
        this.transform.position = mainController.respawnLocation;
        CarRigidbody.velocity = mainController.respawnVelocity;
        CarRigidbody.angularVelocity = mainController.respawnAngularVelocity;
    }
}