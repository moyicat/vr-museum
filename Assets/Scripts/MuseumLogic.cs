using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuseumLogic : MonoBehaviour {

	public GameObject welcomeUI;
	public AudioClip welcome;
	public AudioClip start;

	public bool iTweenTriggered = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void readyClick() {
    	welcomeUI.SetActive(false);
        this.GetComponent<GvrAudioSource>().clip = welcome;
        this.GetComponent<GvrAudioSource>().Play();
	}

	public void iTweenClick() {
		if (!iTweenTriggered) {
            this.GetComponent<GvrAudioSource>().clip = start;
        	this.GetComponent<GvrAudioSource>().Play();
			iTweenTriggered = true;
		}
	}

	public void audioSelection (AudioClip clip) {
		this.GetComponent<GvrAudioSource>().clip = clip;
		this.GetComponent<GvrAudioSource>().Play();
	}
}