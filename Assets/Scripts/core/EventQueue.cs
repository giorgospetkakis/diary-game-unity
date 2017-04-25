using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventQueue : MonoBehaviour {

	public TextCue NarrationTextFeed;
	public int linesSinceCheckpoint = 0;
	int lastMini = 0, lastCutScene = 0;

	public void runLineQueue() {
		NarrationTextFeed.showNextLine();
		linesSinceCheckpoint++;
		Debug.Log(linesSinceCheckpoint);
	}

	public void loadNextMiniGame() {
		GetComponent<MiniGameMngr>().LoadMiniGame(lastMini++);
		GetComponent<TransitionController>().setTransitionStatus(false);
	}

	public void finishMiniGame() {
		GetComponent<MiniGameMngr>().DespawnMini();
		GetComponent<TransitionController>().setTransitionStatus(true);
	}

	public void loadNextCutScene() {
		GetComponent<CutsceneMngr>().LoadBackdrop(lastCutScene++);
	}

	public void despawnCutscene() {
		GetComponent<CutsceneMngr>().DespawnBackdrop();
	}

	public void setLineCheckpoint() {
		linesSinceCheckpoint = 0;
	}
}
