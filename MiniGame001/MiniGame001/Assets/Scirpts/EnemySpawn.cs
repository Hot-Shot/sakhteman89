﻿using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject[] enemies;
	Vector2 whereToSpawn;
	public float myTimer;
	public float spawnrate = 4f;
	public float posX = 1.7f;
	float nextspawn = 0.0f;
	public int a=0;
	public float c=1.5f;
	public float i=0.4f;
	public float dlytime=0.0f;
	public float myTimer3=0.0f;
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
		if (PauseMenu.GameIsPaused == false)
		{
			myTimer = myTimer + Time.deltaTime;
			myTimer3=myTimer3+Time.deltaTime;
			if (myTimer >= 10) {
				c-=0.1f;
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
			if(myTimer3>c){
			if (Time.time > nextspawn) {
				nextspawn = Time.time + spawnrate - i;
				randEnemy = Random.Range (0, 3);
				whereToSpawn = new Vector2 (posX, transform.position.y);
				Instantiate (enemies [randEnemy], whereToSpawn, gameObject.transform.rotation);		
			}
			}

		}
		else
		{
			myTimer3=0.0f;
		}
		
	}
	
}