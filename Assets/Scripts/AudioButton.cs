using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour {

	public GameObject player;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void audioSelection() {
		player.GetComponent<MuseumLogic>().audioSelection(clip);
		this.GetComponent<GvrAudioSource>().Play();
	}
}