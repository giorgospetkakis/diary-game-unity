using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichSoundCue : MonoBehaviour {

	public AudioClip[] sounds;
	AudioSource source;
	bool ja;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}

	public void drop() {
		if(!ja){
			source.clip = sounds [0];
			source.Play();
		}
		ja = false;
	}

	public void complete() {
		source.clip = sounds[1];
		source.Play();
	}

	public void add() {
		source.clip = sounds[2];
		source.Play();
		ja = true;
	}
}
