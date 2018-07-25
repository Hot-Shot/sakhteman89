using UnityEngine;
using System.Collections;

public class Loop : MonoBehaviour {
	public float speed=0.05f;
	public float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if (myTimer >= 10) {
			speed += 0.045f;
		}
		if (myTimer > 10) {
			myTimer = 0f;
		}
		Vector2 offset = new Vector2 (0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
