using UnityEngine;
using System.Collections;

public class CameraMovement2 : MonoBehaviour {
	public GameObject Hearth1;
	public GameObject Hearth2;
	public GameObject Hearth3;
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
		if (Lives.miss == 2) {
			Hearth1.SetActive (true);
		}
		if (Lives.miss == 1)
		{
			Hearth2.SetActive(true);
		}
		if (Lives.miss == 0)
		{
			Hearth3.SetActive(true);
		}


	}
}