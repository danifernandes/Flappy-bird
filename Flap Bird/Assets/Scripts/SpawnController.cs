using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnController : MonoBehaviour {

	public float maxHeight;
	public float minHeight;

	public float rateSpawn;
	public float currentRateSpawn;
	public GameObject pipesPrefab;

	public int maxSpawnPipes;

	public List<GameObject> pipes;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < maxSpawnPipes; i++) {
			GameObject tempPipes = Instantiate(pipesPrefab) as GameObject;
			pipes.Add(tempPipes);
			tempPipes.SetActive(false);
			currentRateSpawn = rateSpawn;
		}
	}
	
	// Update is called once per frame
	void Update () {
		currentRateSpawn += Time.deltaTime;

		if(currentRateSpawn > rateSpawn) {
			currentRateSpawn = 0;
			Spawn();
		}
	}


	private void Spawn () {
		float randHeight = Random.Range (minHeight, maxHeight);

		GameObject tempPipes = null;

		for (int i = 0; i < maxSpawnPipes; i++) {

			if(pipes[i].activeSelf == false) {
				tempPipes = pipes[i];
				break;
			}

		}

		if (tempPipes != null) {
			tempPipes.transform.position = new Vector3(transform.position.x, randHeight, transform.position.z);
			tempPipes.SetActive(true);
		}
	}
}
