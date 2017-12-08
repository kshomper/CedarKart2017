using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointActivator : MonoBehaviour {

    private Collider checkCollider;
    private Material mat;
    private float triggerTime;
    public float inactiveTimer = 30f;
    public bool active = true;

	// Use this for initialization
	void Start () {
        checkCollider = this.GetComponent<Collider>();
        checkCollider.enabled = true;
        mat = this.GetComponent<Renderer>().material;
	}

    // Update is called once per frame
    void Update()
    {
        if (!active && Time.time > (triggerTime + inactiveTimer))
        {
            active = true;
            checkCollider.enabled = true;
            mat.SetColor("_EmissionColor", new Color(.227f, .227f, 0f));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerTime = Time.time;
        active = false;
        checkCollider.enabled = false;
        mat.SetColor("_EmissionColor", new Color(.466f, .0f, 0f));
    }
}
