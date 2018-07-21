using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
//Variables	
	int i = 1;
	public GameObject enemy;
	public GameObject enemy2;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 5f;
	float nextSpawn = 0.5f;

//Spawn Locations
	void Update () {
		
		i++;
		if (i % 2 == 0) {
			if (Time.time > nextSpawn) {
				nextSpawn = Time.time + spawnRate;
				randX = Random.Range (-5f, 5f);
				whereToSpawn = new Vector2 (randX, transform.position.y);
				Instantiate (enemy, whereToSpawn, Quaternion.identity);
				
			}
		}
		else 
		{  
			if (Time.time > nextSpawn) {
				nextSpawn = Time.time + spawnRate;
				randX = Random.Range (-0f, 5f);
				whereToSpawn = new Vector2 (randX, transform.position.y);
				Instantiate (enemy2, whereToSpawn, Quaternion.identity);
			}
		}
		
	}
}