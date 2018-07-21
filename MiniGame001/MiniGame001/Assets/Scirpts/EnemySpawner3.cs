using UnityEngine;
using System.Collections;

public class EnemySpawner3 : MonoBehaviour {
	public GameObject[] enemies;
	Vector2 whereToSpawn;
	public float spawnrate = 5f;
	public float posX = -1.7f;
	float nextspawn = 0.0f;
	int randEnemy;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextspawn)
		{
			nextspawn=Time.time + spawnrate;
			randEnemy = Random.Range (0, 3);
			whereToSpawn = new Vector2 (posX, transform.position.y);
			Instantiate (enemies[randEnemy], whereToSpawn , gameObject.transform.rotation);		
		}
		
	}
	
}