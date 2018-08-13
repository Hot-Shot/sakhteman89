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
	public float dlytime=0.4f;
	public int u=0;
	public float c=0.5f;
	public float myTimer3=0.0f;
	int randEnemy;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (PauseMenu.GameIsPaused == false) {
			myTimer3=myTimer3+Time.deltaTime;
			myTimer = myTimer + Time.deltaTime;
			if (myTimer >= 10) {
				c-=0.1f;
				a += 1;
				spawnrate -= 1.5f;
				myTimer = 0;
			}
			if (spawnrate <= 1) {
				spawnrate += dlytime;
			}
			if (dlytime <= 0.01) {
				dlytime += 0.2f;
			}
			if (a >= 2) {

				dlytime -= 0.1f;
				a = 0;
			}
			if(myTimer3>c){
				if (Time.time > nextspawn) {
					randEnemy = Random.Range (0, 9);
					u=randEnemy;
					nextspawn = Time.time + spawnrate - dlytime;
					whereToSpawn = new Vector2 (posX, transform.position.y);
					if (u>=3)
					{
						whereToSpawn = new Vector2(-0.82f, transform.position.y);
						Instantiate (enemies [randEnemy], whereToSpawn, gameObject.transform.rotation);
					}
					else if (u<3)
					{
						Instantiate (enemies [randEnemy], whereToSpawn, gameObject.transform.rotation);		
					}
				}
			}
	
		}
		else
		{
			myTimer3=0.0f;
		}
		
	}
	
}