using UnityEngine;
using System.Collections;

public class Loop : MonoBehaviour {
	public float speed=0.1f;
	public float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTimer = myTimer + Time.deltaTime;
		if (myTimer >= 10)
		{
			speed+=0.042f;
			myTimer=0;
		}
		if (PauseMenu.GameIsPaused == false && Lives.miss>0)
		{
			Vector2 offset = new Vector2 (0, Time.time * speed);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
		}
	}
}
