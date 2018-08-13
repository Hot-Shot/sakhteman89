using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject[] enemies;
	Vector2 whereToSpawn;
	public float myTimer;
	public float spawnrate = 4f;
	public float posX = 1.7f;
	float nextspawn = 0.0f;
	public int a=0;
	public float c=0.5f;
	public float dlytime=0.4f;
	public float myTimer3=0.0f;
	int randEnemy;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//We Check If The Game is Paused Or Not
		if (PauseMenu.GameIsPaused == false)
		{
			//We Use 2 Timers: 1 For Checking The Speed of The Camera & 1 For Making a Dly When The Game is Paused Or Resumed!
			myTimer = myTimer + Time.deltaTime;
			myTimer3=myTimer3+Time.deltaTime;
			//After The Timer Hits 10 Seconds We Make The Dly For Pausing The Game Lower, Also We Make The Speed of The Spawning Faster Than Before
			//By Lowering The Spawn Rate Time
			//We Make A Loop By Making The Timer Go to 0 Again
			if (myTimer >= 10) {
				c-=0.1f;
				a += 1;
				spawnrate -= 1.5f;
				myTimer = 0;
			}
			//We Check If The SpawnRate Got Lower Than 0 and We Make it Go a Little Bit Higher
			if (spawnrate <= 1) {
				spawnrate += dlytime;
			}
			//We Make The i Go A Little Higher In Case it Got To 0.01
			if (dlytime <= 0.01) {
				dlytime += 0.2f;
			}
			//To Check That Every 2 Times That the Camera Got more Speed The DlyTime Gets 0.1 Lower
			if (a >= 2) {
			
				dlytime -= 0.1f;
				a = 0;
			}
			//a Timer to Make a Dly When The game is Paused	
			if(myTimer3>c)
			{
				//We Start The Spawner At This Point, the NextSpawn Value is for The Time That The Spawner Activates
				//I put The RandEnemy Array for Puting Random Enemies in a Box And Chosing From it
				// WhereToSpawn is For Getting The X & Y Position, The Y of Our Game is just Changing by The CameraMovement so we don't Change That
				//Also The PosX is a Value That Never Changes
				//Instantiate Code is For Building an Object In Unity
			if (Time.time > nextspawn) 
			{
				nextspawn = Time.time + spawnrate - dlytime;
				randEnemy = Random.Range (0, 5);
				whereToSpawn = new Vector2 (posX, transform.position.y);
				Instantiate (enemies [randEnemy], whereToSpawn, gameObject.transform.rotation);		
			}
			}

		}
		//if The Game Is Paused We Make A Dly By Taking The timer To 0
		else
		{
			myTimer3=0.0f;
		}
		
	}
	
}