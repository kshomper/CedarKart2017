using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour {

	public void masterVolume(float f){
		AudioListener.volume = f;
	}

}
