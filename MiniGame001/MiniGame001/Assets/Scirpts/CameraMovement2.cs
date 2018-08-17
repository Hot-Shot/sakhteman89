using UnityEngine;
using System.Collections;

public class CameraMovement2 : MonoBehaviour {
	public float speed;
	Vector3 lastPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gameHasEnded||PauseMenu.GameIsPaused)
			return;
		transform.Translate (Vector2.up * Time.deltaTime * speed * (Mathf.Sqrt( transform.position.y / 100)+1));
		Vector3 velocity = (this.transform.position - lastPos);

	}
}