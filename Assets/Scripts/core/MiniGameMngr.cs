using UnityEngine;
using UnityEngine.UI;

public class MiniGameMngr : MonoBehaviour {

	public GameObject [] minigames;

	private MiniGame currMini;
	private GameObject currMiniHolder;

	public void LoadMiniGame(int mIndex) {
		if (mIndex < minigames.Length) {
			Destroy(currMiniHolder);
			// Find minigame in array
			currMini = minigames[mIndex].GetComponent<MiniGame>();

			currMiniHolder = Instantiate(currMini.gameObject) as GameObject;

			currMini.init();
			currMini.begin();
			Debug.Log("Minigame " + mIndex + " loaded");
		} else {
			Debug.Log("Minigame index " + mIndex + " is out of bounds");
		}
	}

	// Use this for initialization
	void Start () {
		LoadMiniGame(0);
	}
}

		// Vector2 release = ((Vector2) sling.position - endPoint).normalized * damp;
		// Debug.Log(release);
		// GameObject temp_projectile = Instantiate(projectile, sling.position, Quaternion.identity) as GameObject;
		// temp_projectile.transform.parent = projectiles;
		// temp_projectile.GetComponent<Rigidbody2D>().AddForce(release);