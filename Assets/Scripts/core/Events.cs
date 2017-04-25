using UnityEngine;

public class Events : MonoBehaviour {

	EventQueue q;
	int lineBlockIndex;
	int[] blockSize;

	// Use this for initialization
	void Start () {
		q = GetComponent<EventQueue>();
		blockSize = new int[] {34};
		lineBlockIndex = 0;

		//q.loadNextCutScene();
	}
	
	// Update is called once per frame
	void Update () {
			// INTRODUCTION
			if(q.linesSinceCheckpoint == blockSize[lineBlockIndex]) {
				q.despawnCutscene();
				q.loadNextMiniGame();
				q.setLineCheckpoint();
			}
	}

	void moveToNextBlock() {
		lineBlockIndex++;
	}
}
