﻿using UnityEngine;
using System.Collections;
	
	public class EnemySpawn : MonoBehaviour {
		public GameObject[] enemies;
		Vector2 whereToSpawn;
		public float myTimer;
		public float spawnrate = 4f;
		public float posX = 1.7f;
		float nextspawn = 0.0f;
		int randEnemy;
		
		// Use this for initialization
		void Start () {
			myTimer= myTimer + Time.deltaTime;
		}
		
		// Update is called once per frame
		void Update () {
			myTimer= myTimer + Time.deltaTime;
			if(myTimer>=10)
			{
				spawnrate -= 1.5f;
			}
			if(myTimer>10)
			{
				myTimer=0;
			}	
			if (spawnrate <= 1) {
				spawnrate += 1.5f;
			}
			if(Time.time > nextspawn)
			{
				nextspawn=Time.time + spawnrate;
				randEnemy = Random.Range (0, 3);
				whereToSpawn = new Vector2 (posX, transform.position.y);
				Instantiate (enemies[randEnemy], whereToSpawn , gameObject.transform.rotation);		
			}

		}
			
	}