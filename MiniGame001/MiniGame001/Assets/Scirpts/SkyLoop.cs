using UnityEngine;
using System.Collections;

public class SkyLoop : MonoBehaviour {
	public float speed=0.1f;
	public float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PauseMenu.GameIsPaused == false) {
			myTimer = myTimer + Time.deltaTime;
			speed += 0.000001f;
			myTimer = 0;
			Vector2 offset = new Vector2 (Time.time * speed, 0);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
		}
	}
	
}
