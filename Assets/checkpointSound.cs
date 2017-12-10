using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointSound : MonoBehaviour {

    public AudioClip happyNoise;
    private AudioSource audiosource;


    void Awake()
    {
        audiosource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter()
    {
        audiosource.PlayOneShot(happyNoise, 1f);
    }
}
