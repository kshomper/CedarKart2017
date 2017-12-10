using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whooshTrigger : MonoBehaviour {

    public AudioClip whoosh;
    private AudioSource audiosource;


    void Awake()
    {
        audiosource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter() 
    {
        audiosource.PlayOneShot(whoosh, 1f);
    }

}
