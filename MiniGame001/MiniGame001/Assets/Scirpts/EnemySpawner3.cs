using UnityEngine;
using System.Collections;

public class EnemySpawner3 : MonoBehaviour {
	public GameObject[] enemies;
	Vector2 whereToSpawn;
	public float myTimer;
	public float spawnrate = 4f;
	public float posX = 1.7f;
	float nextspawn = 0.0f;
	public int a=0;
	public float i=0.4f;
	public float dlytime=0.0f;
	public int u=0;
	int randEnemy;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (PauseMenu.GameIsPaused == false) {
			myTimer = myTimer + Time.deltaTime;
			if (myTimer >= 10) {
				a += 1;
				spawnrate -= 1.5f;
				myTimer = 0;
			}
			if (spawnrate <= 1) {
				spawnrate += i;
			}
			if (i <= 0.01) {
				i += 0.2f;
			}
			if (a >= 2) {

				i -= 0.1f;
				a = 0;
			}
		

			if (Time.time > nextspawn) {
				nextspawn = Time.time + spawnrate - i;
				randEnemy = Random.Range (0, 6);
				u=randEnemy;
				whereToSpawn = new Vector2 (posX, transform.position.y);
				if (u==3 || u==4 || u==5)
				{
					whereToSpawn = new Vector2(-0.82f, transform.position.y);
					Instantiate (enemies [randEnemy], whereToSpawn, gameObject.transform.rotation);
					dlytime=0f;
				}
				else if (u==0 || u==1 || u==2)
				{
					Instantiate (enemies [randEnemy], whereToSpawn, gameObject.transform.rotation);		
					dlytime=0f;
				}
				
			}

		}
		
	}
	
}