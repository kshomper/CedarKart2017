using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioStart : MonoBehaviour {
	
	public AudioMixer music;
	public AudioMixer background;
	float startTime;
	bool startAudio;
	// Use this for initialization
	void Start () {
		background.SetFloat ("BackVol", -80f);
		music.SetFloat ("MusicVol", -80f);
		startTime = Time.time + 5f;
		startAudio = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (startTime < Time.time) {
			startAudio = false;
		}
		if (!startAudio) {
			background.SetFloat ("BackVol", 0);
			music.SetFloat ("MusicVol", 0);
		}
	}
}
