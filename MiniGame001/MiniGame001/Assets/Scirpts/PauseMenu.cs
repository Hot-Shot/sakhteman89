using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;

	
	
	// Update is called once per frame
	void Update () {
	}
		public void pause(){
			if (GameIsPaused)
			{
				Resume ();
			}
			else 
			{
				Pause ();
			}
		}

		public void Resume()
		{
			PauseMenuUI.SetActive(false);
			GameIsPaused = false;
		}
		void Pause()
		{
			PauseMenuUI.SetActive(true);
			GameIsPaused = true;
		}
	public void Menu(){
		GameIsPaused = false;
		Application.LoadLevel ("Sequence 0");
	}
	public void Restart(){
		GameManager.gameHasEnded = false;
		Lives.miss = 3;
		ScoringSystem.score = 0;
		Application.LoadLevel (Application.loadedLevel);
		GameIsPaused = false;
	}
	public void QuitGame()
	{
		Application.Quit ();
	}

}
