using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused) {
				Resume ();
			} else {
				Pause ();
			}
		}
	}

		void Resume()
		{
			PauseMenuUI.SetActive(false);
			GameIsPaused = false;

		}
		void Pause()
		{
			PauseMenuUI.SetActive(true);
			GameIsPaused = true;
		}
}
