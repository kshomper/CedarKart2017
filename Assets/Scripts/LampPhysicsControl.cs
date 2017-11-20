using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampPhysicsControl : MonoBehaviour {

    Rigidbody rb;
    Collider col;
    Collider terrainCollider;
    public bool useGravityHere = true;
    public float forceOnCollision = 0;

    private void Start()
    {
        terrainCollider = GameObject.FindGameObjectWithTag("Terrain").GetComponent<Collider>();
        rb = this.GetComponent<Rigidbody>();
        col = this.GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other != terrainCollider)
        {
            rb.constraints = RigidbodyConstraints.None;
            col.isTrigger = false;
            rb.useGravity = useGravityHere;
            rb.AddRelativeForce(new Vector3(0, forceOnCollision, 0));
        }
    }
}
