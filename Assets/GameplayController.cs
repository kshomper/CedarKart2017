using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public int lives = 3;
    public bool addScore;
    private int nextUpdate = 1;
    private Rigidbody CarRigidbody;
    private GameMaster mainController;


    private void Start()
    {
        mainController = GameObject.Find("Master Gameplay Controller").GetComponent<GameMaster>();
        addScore = true;
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
			if(addScore) {
	            mainController.AddPoints(20);
			}
            mainController.ResetTimer();
        }
        else
        {
            //IDK
        }
    }

    private void Die()
    {
        lives -= 1;
        
        if(lives <= 0)
        {
            mainController.GameOver();
        }
        this.transform.position = new Vector3(47.3f, 9.571f, -48.7f);
        CarRigidbody.velocity = new Vector3(0, 0, 0);
        CarRigidbody.angularVelocity = new Vector3(0, 0, 0);
    }
}
