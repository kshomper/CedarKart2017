using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour {

	public AudioMixer alienMixer;
	public AudioMixer backgroundMixer;
	public AudioMixer carMixer;
	public AudioMixer checkpointMixer;
	public AudioMixer musicMixer;

	public void masterVolume(float f){
		AudioListener.volume = f;
	}

	public void musicVolume(float f){
		//GameObject[] musics = GameObject.FindGameObjectsWithTag ("MUSIC");
		//foreach (GameObject music in musics){
			//music.GetComponent<AudioSource>().volume = f;	
		//}
		musicMixer.SetFloat ("MusicVol", f);
	}

	public void sfxVolume(float f){
		alienMixer.SetFloat ("AlienVol", f);
		backgroundMixer.SetFloat ("BackVol", f);
		carMixer.SetFloat ("CarVol", f);
		checkpointMixer.SetFloat ("CheckVol", f);
	}
}
