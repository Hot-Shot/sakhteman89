using UnityEngine;
using System.Collections;

public class BuildingLoop : MonoBehaviour {
	
	public GameObject block;
	float timer;
	float randY;
	float randX;
	float k=0;
	Vector2 whereToSpawn;
	public float spawnRate = 1f;
	float nextSpawn = 0.5f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randY = Random.Range (-5f, 5f);
			whereToSpawn = new Vector2 (randX, transform.position.y);
			Instantiate (block, whereToSpawn, Quaternion.identity);
		}

	}
}