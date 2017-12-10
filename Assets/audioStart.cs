using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioStart : MonoBehaviour {
	
	public AudioMixer background;
	float startTime;
	bool startAudio;

	// Use this for initialization
	void Start () {
		startTime = Time.time + 3.2f;
		startAudio = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (startTime < Time.time) {
			startAudio = false;
		}
		if (!startAudio) {
			background.SetFloat ("BackVol", 0);
		}
	}
}
