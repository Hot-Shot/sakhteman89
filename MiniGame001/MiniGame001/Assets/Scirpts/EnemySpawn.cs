using UnityEngine;
using System;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject[] windowWithEnemy;
	public GameObject[] noEnemyWindow;
	public GameObject[] BalconyWithEnemy;
	public GameObject[] BalconyWithNoEnemy;
	public GameObject[] spawnPoints = new GameObject[3];
	public float enemyDistances;
	GameObject lastItem;



	// Use this for initialization
	void Start () {
		RandomizeEnemy ();
	}

	void Update()
	{
		if (PauseMenu.GameIsPaused || GameManager.gameHasEnded) 
			return;
		if (enemyDistances > (this.transform.position.y - lastItem.transform.position.y))
			return;

		RandomizeEnemy ();
	}

	void RandomizeEnemy()
	{
		int r = UnityEngine. Random.Range (0,5);

		for (int i = 0; i < 3; i++) {
			if (UnityEngine.Random.Range (0, 2) == 1) {



				if(UnityEngine.Random.Range (0, 2) == 1)
				{
					SpawnWindowWithEnemy(i);				
				}
				else
				{
					if(i != 1)
					{
						SpawnWindowWithEnemy(i);
					}else{
						
						lastItem = (GameObject)Instantiate (BalconyWithEnemy [UnityEngine.Random.Range (0, BalconyWithEnemy.Length )],
						                                    spawnPoints [i].transform.position, Quaternion.identity);
						i++;
					}
				}
			} else {
				if(UnityEngine.Random.Range (0, 2) == 1)
				{
					SpawnWindowWithNoEnemy(i);				
				}
				else
				{
					if(i != 1)
					{
						SpawnWindowWithNoEnemy(i);
					}else{
						
						lastItem = (GameObject)Instantiate (BalconyWithNoEnemy [UnityEngine.Random.Range (0, BalconyWithNoEnemy.Length)],
						                                    spawnPoints [i].transform.position, Quaternion.identity);
						i++;
					}
				}
			}
		}
	}


	void SpawnWindowWithEnemy(int i)
	{
		lastItem = (GameObject)Instantiate (windowWithEnemy [UnityEngine.Random.Range (0, windowWithEnemy.Length)],
		                                    spawnPoints [i].transform.position, Quaternion.identity);
	}
	
	void SpawnWindowWithNoEnemy( int i)
	{
		lastItem = (GameObject)Instantiate (noEnemyWindow [UnityEngine.Random.Range (0, noEnemyWindow.Length)],
		                                    spawnPoints [i].transform.position, Quaternion.identity);
		
	}

}