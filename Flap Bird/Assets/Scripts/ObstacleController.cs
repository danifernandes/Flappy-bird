using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;
		
		if (transform.position.x < -0.1f) {
			gameObject.SetActive(false);
		}
	}
}