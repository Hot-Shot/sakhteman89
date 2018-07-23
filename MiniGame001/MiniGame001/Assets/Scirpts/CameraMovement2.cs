using UnityEngine;
using System.Collections;

public class CameraMovement2 : MonoBehaviour {
	public float myTimer = 0.0f;
	public float i = 0.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		transform.Translate (0, i, 0);
		if(myTimer>=10)
		{
			i+=0.01f;
		}
		if (myTimer > 10) 
		{
			myTimer = 0f;
		}
	}
}