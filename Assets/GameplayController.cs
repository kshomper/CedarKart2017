using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    private Rigidbody CarRigidbody;
    public GameMaster mainController;
    int lives;
    private bool addScore;
    private Text livesText;

    Animator anim;

    public int Lives
    {
        get
        {
            return lives;
        }

        set
        {
            lives = value;
        }
    }

    public Animator Anim
    {
        get
        {
            return anim;
        }

        set
        {
            anim = value;
        }
    }

    private void Start()
    {
        Lives = mainController.startLives;
        addScore = mainController.addScore;
        livesText = mainController.livesText;
        livesText.text = "Lives: " + Lives;
        CarRigidbody = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
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
        Lives -= 1;
		livesText.text = "Lives: " + Lives;
        transform.position = mainController.respawnLocation;
        CarRigidbody.velocity = mainController.respawnVelocity;
        CarRigidbody.angularVelocity = mainController.respawnAngularVelocity;
    }
}