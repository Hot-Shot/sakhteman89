using UnityEngine;
using System.Collections;
	
	public class EnemySpawn : MonoBehaviour {
		public GameObject[] enemies;
		Vector2 whereToSpawn;
		public float spawnRate = 5f;
		public bool stop;
		public float posX = 1.7f;
		int randEnemy;
		// Use this for initialization
		void Start () {
		}
		
		// Update is called once per frame
		void Update () {
		while (!stop) {
			randEnemy = Random.Range (0, 6);
			whereToSpawn = new Vector2 (posX, transform.position.y);
			Instantiate (enemies[randEnemy], whereToSpawn , gameObject.transform.rotation);			
		}
		}
			
	}