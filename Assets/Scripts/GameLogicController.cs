using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicController : MonoBehaviour {
	Camera mainCam;
	public Camera inGameMenuCam;
	private bool isPaused = false;

	// Use this for initialization
	void Start () {
		mainCam = Camera.main;
		inGameMenuCam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Call in-game menu fn
		if(Input.GetKeyDown (KeyCode.Escape)){
			InGameMenu ();
		}
		
	}

	public void InGameMenu(){
		if (!isPaused) {
			isPaused = true;
			mainCam.enabled = false;
			inGameMenuCam.enabled = true;
			;
		} 
		else {
			inGameMenuCam.enabled = false;
			mainCam.enabled = true;
			isPaused = false;
		}

	}
}
