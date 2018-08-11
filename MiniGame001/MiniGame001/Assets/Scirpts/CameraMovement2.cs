using UnityEngine;
using System.Collections;

public class CameraMovement2 : MonoBehaviour {
	public GameObject H1;
	public GameObject H2;
	public GameObject H3;
	public float myTimer = 0.0f;
	public float i = 0.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Lives.miss == 2) 
		{
			H1.SetActive(true);
		}
		if (Lives.miss == 1)
		{
			H2.SetActive(true);
		}
		if (Lives.miss == 0) {
			H3.SetActive (true);
		}
		if (PauseMenu.GameIsPaused == false && GameManager.gameHasEnded == false) {
			myTimer += Time.deltaTime;
			transform.Translate (0, i, 0);
			if (myTimer >= 10) {
				i += 0.01f;
			}
			if (myTimer > 10) {
				myTimer = 0f;
			}
		}
	}
}