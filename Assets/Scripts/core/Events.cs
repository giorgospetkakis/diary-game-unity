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
			if(q.linesSinceCheckpoint == 10) {
				q.loadNextMiniGame();
				q.setLineCheckpoint();
			}
	}
}
