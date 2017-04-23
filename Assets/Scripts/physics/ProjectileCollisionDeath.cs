using UnityEngine;

public class ProjectileCollisionDeath : MonoBehaviour {
	
	public int maxCollisions = 4;
	int collisions;

	// Use this for initialization
	void Start () {
		collisions = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(collisions > maxCollisions) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		collisions += 1;
	}
}
