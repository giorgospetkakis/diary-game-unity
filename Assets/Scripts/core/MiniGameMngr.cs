using UnityEngine;
using UnityEngine.UI;

public class MiniGameMngr : MonoBehaviour {

	public GameObject [] minigames;

	private MiniGame currMini;
	private GameObject currMiniHolder;
	public GameObject miniGameHolder;

	public void LoadMiniGame(int mIndex) {
		if (mIndex < minigames.Length) {
			// Find minigame in array
			currMini = minigames[mIndex].GetComponent<MiniGame>();

			currMiniHolder = Instantiate(currMini.gameObject) as GameObject;
			currMiniHolder.transform.parent = miniGameHolder.transform;

			currMini.init();
			currMini.begin();
			Debug.Log("Minigame " + mIndex + " loaded");
		} else {
			Debug.Log("Minigame index " + mIndex + " is out of bounds");
		}
	}

	public void DespawnMini() {
		Destroy(currMiniHolder);
	}

	// Use this for initialization
	void Start () {
		
	}
}