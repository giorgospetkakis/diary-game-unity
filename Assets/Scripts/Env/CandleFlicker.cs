using UnityEngine;

public class CandleFlicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float i = GetComponent<Light>().intensity;
		GetComponent<Light>().intensity = Mathf.Max(1.3f, (Mathf.Min ( 1.8f, Mathf.Lerp(i, i + Random.Range(-0.2f,0.2f), 0.1f))));
	}
}
