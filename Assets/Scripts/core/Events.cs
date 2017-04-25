using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {

	EventQueue q;


	// Use this for initialization
	void Start () {
		q = GetComponent<EventQueue>();
	}
	
	// Update is called once per frame
	void Update () {
			// INTRODUCTION
			if(q.linesSinceCheckpoint == 34) {
				q.loadNextMiniGame();
				q.setLineCheckpoint();
			}
	}
}
