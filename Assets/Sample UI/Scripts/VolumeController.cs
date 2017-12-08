using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour {

	public void masterVolume(float f){
		AudioListener.volume = f;
	}

	public void musicVolume(float f){
		GameObject[] musicTracks;
		musicTracks = GameObject.FindGameObjectsWithTag ("MUSIC");
		foreach (GameObject music in musicTracks) {
			music.GetComponent<AudioSource> ().volume = f;
		}
	}

	public void sfxVolume(float f){
		GameObject[] sfxTracks;
		sfxTracks = GameObject.FindGameObjectsWithTag ("SFX");
		foreach (GameObject music in sfxTracks) {
			music.GetComponent<AudioSource> ().volume = f;
		}
	}
}
