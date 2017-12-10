using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class ufoNav : MonoBehaviour {

	private float distanceCar;
	private float distanceRespawn;
	private float respawnTime;
	private bool isRespawned;
	public Transform respawnPt;
	public Transform player;
	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent ufo;


	void Start () {
		ufo = GetComponent<NavMeshAgent>();
		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		ufo.autoBraking = false;
		isRespawned = false;
		GotoNextPoint();
	}


	void GotoNextPoint() {
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		ufo.destination = points[destPoint].position;

		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = (destPoint + 1) % points.Length;
	}


	void Update () {

		distanceCar = Vector3.Distance(ufo.transform.position, player.position);
		distanceRespawn = Vector3.Distance(respawnPt.position, player.position);
		if (distanceRespawn < 5f) {
			respawnTime = Time.time + 5f;
		}
		//chase car if it's close (ignore if the car is within 5 sec of respawning)
		if(distanceCar < 50 && Time.time > respawnTime){
			ufo.SetDestination (player.position);
		}
		// Choose the next destination point when the agent gets
		// close to the current one.
		else if (!ufo.pathPending && ufo.remainingDistance < 0.5f)
			GotoNextPoint();
	}
} 

