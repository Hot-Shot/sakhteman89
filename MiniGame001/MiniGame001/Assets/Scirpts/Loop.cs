using UnityEngine;
using System.Collections;

/// <summary>
/// sequence1 => main camera => building 
/// </summary>

public class Loop : MonoBehaviour {


	public float speed;
	public float myTimer = 0.0f;

	
	Vector3 _cameraLastPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//if we're not puased
		if (PauseMenu.GameIsPaused == false) {
			//we give my timer the delta time value
			myTimer = myTimer + Time.deltaTime;
			//if mytimer hit 10 seconds:

			//if we're not puased and we still have hp
			if (PauseMenu.GameIsPaused == false && Lives.miss > 0) {
				Vector2 offset = new Vector2 (0, (_cameraLastPos - Camera.main.transform.position).y / 15);
				_cameraLastPos = Camera.main.transform.position;
				GetComponent<Renderer> ().material.mainTextureOffset =GetComponent<Renderer> ().material.mainTextureOffset - offset;
			}
		}
	}
}
