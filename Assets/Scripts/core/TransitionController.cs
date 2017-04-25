using UnityEngine;

public class TransitionController : MonoBehaviour {

	bool inTransition;

	// Use this for initialization
	void Start () {
		inTransition = true;		
	}
	
	// Update is called once per frame
	void Update () {
		if (inTransition) {
			if (Input.GetMouseButtonDown(0)) {
				GetComponent<EventQueue>().runLineQueue();
			}
		}
	}

	public void setTransitionStatus(bool status) {
		inTransition = status;
	}
}
