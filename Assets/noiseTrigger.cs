using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noiseTrigger : MonoBehaviour {

    public AudioClip clang;
    private AudioSource audiosource;


    void Awake()
    {
        audiosource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter()
    {
        audiosource.PlayOneShot(clang, 1f);
    }
}
