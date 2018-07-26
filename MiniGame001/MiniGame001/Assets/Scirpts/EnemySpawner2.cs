using UnityEngine;
using System.Collections;

public class EnemySpawner2 : MonoBehaviour {
	public GameObject[] enemies;
	Vector2 whereToSpawn;
	public float myTimer;
	public float spawnrate = 4f;
	public float posX = 0f;
	float nextspawn = 0.0f;
	public int a=0;
	public float i=0.4f;
	public int c = 0;
	public float dlytime=0.0f;
	int randEnemy;
	// Use this for initialization
	public void awake(){
		if (PauseMenu.GameIsPaused == true) {
			dlytime+=1f;
		}
	}
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
				dlytime+=0.1f;
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
				dlytime=0f;
				nextspawn = Time.time + spawnrate - i + dlytime;
				randEnemy = Random.Range (0, 3);
				whereToSpawn = new Vector2 (posX, transform.position.y);
				if (FindObjectOfType<EnemySpawner3>().u==4 || FindObjectOfType<EnemySpawner3>().u==5 || FindObjectOfType<EnemySpawner3>().u==6)
				{
					c+=1;
				}
				else
				{
				Instantiate (enemies [randEnemy], whereToSpawn, gameObject.transform.rotation);
				}
			}
		}
		
	}
	
}