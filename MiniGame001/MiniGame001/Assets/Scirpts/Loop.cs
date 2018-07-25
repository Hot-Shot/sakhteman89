using UnityEngine;
using System.Collections;

public class Loop : MonoBehaviour {
	public float speed=0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		myTimer += Time.deltaTime;
		if (myTimer >= 10) {
			speed += 0.045f;
		}
		if (myTimer > 10) {
			myTimer = 0f;
		}
=======
>>>>>>> parent of e4dab28... buildingLoop
=======
>>>>>>> parent of e4dab28... buildingLoop
		Vector2 offset = new Vector2 (0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
=======
		if (PauseMenu.GameIsPaused == false && Lives.miss>0)
		{
			Vector2 offset = new Vector2 (0, Time.time * speed);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
		}
>>>>>>> fd17175614bf16adc07da4f8a69f05dd1a976f63
=======
		Vector2 offset = new Vector2 (0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
>>>>>>> parent of fd17175... GameOverDesigned
=======
		Vector2 offset = new Vector2 (0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
>>>>>>> parent of fd17175... GameOverDesigned
	}
}
