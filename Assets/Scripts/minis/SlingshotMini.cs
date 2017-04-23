using UnityEngine;

public class SlingshotMini : MiniGame {

	public GameObject projectile;
	public Transform projectiles;
	public Transform sling;
	public float speed;
	Vector2 endPoint;
	Vector2 startPoint;
	float startTime;
	float releaseTime;
	float maxTime;

	public override void init() {
		speed = 250f;
		startPoint = new Vector2(int.MaxValue, 0);
		maxTime = 1.5f;
	}

	public override void begin() {

	}

	void OnMouseDrag() {
		if(startPoint.x == int.MaxValue) {
			startPoint = Input.mousePosition;
			startTime = Time.time;
		}
		endPoint = Input.mousePosition;
		releaseTime = Time.time;
	}

	void OnMouseUp() {

		if(startPoint.x != endPoint.x && startPoint.y != endPoint.y && startPoint.x != int.MaxValue) {
			Debug.Log(maxTime / (releaseTime - startTime));
			float scale = Mathf.Min(2f, (releaseTime - startTime) / (maxTime / 2f));
			Vector2 release = (startPoint - endPoint).normalized * speed;

			GameObject temp_projectile = Instantiate(projectile, sling.position, Quaternion.identity) as GameObject;
			temp_projectile.transform.parent = projectiles;
			temp_projectile.transform.localScale = new Vector3(scale, scale, scale);
			temp_projectile.GetComponent<Rigidbody2D>().AddForce(release);

			startPoint = new Vector2(int.MaxValue, 0);
		}
	}
}
