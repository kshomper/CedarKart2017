using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody CarRigidbody;
    public GameMaster mainController;

    public void Start()
    {
        CarRigidbody = Player.GetComponent<Rigidbody>();
    }

    public void RespawnPlayer()
    {
        Player.transform.position = mainController.respawnLocation;
        CarRigidbody.velocity = mainController.respawnVelocity;
        CarRigidbody.angularVelocity = mainController.respawnAngularVelocity;
    }
}
