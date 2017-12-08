using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ufoNav : MonoBehaviour
{

	public Transform player;
	public NavMeshAgent ufo;
	public Transform[] points;
	private int destPt;


	// Use this for initialization
	void Start()
	{
		ufo = GetComponent<NavMeshAgent>();
		///destPt = 0;
		//ufo.autoBraking = false;
		//GoToNextPt();
	}

	// Update is called once per frame
	void Update()
	{
		//chase player if they are within xx distance of the current checkpoint (or ufo???)
		//if player is within certian range (increase speed gradualy from 6(patrol) to 10(chase)
		//if 
		ufo.SetDestination(player.position);
		//if (ufo.velocity.magnitude/ufo.speed < 10)
		//{
		//ufo.speed = ufo.speed + .1f;
		//}

		//else //continue patrol (make sure speed goes instantly back to 6). 
		//ufo.speed = 6f;
		//if (ufo.pathPending && ufo.remainingDistance < .5f)
		//{
			//GoToNextPt();
		//}


	}

	//Makes ufo head for next destination in its patrol
	void GoToNextPt()
	{

		ufo.SetDestination(points[destPt].position);
		destPt = (destPt + 1) % points.Length;

	}
}

