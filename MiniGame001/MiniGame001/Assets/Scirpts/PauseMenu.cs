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
		Application.LoadLevel ("Sequence 0");
	}
	public void Restart(){
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		GameManager.gameHasEnded = false;
		Lives.miss = 3;
=======
>>>>>>> parent of fd17175... GameOverDesigned
=======
>>>>>>> parent of fd17175... GameOverDesigned
=======
>>>>>>> parent of fd17175... GameOverDesigned
		ScoringSystem.score = 0;
=======
>>>>>>> parent of 39ad3e4... GameOverPre
=======
>>>>>>> parent of 39ad3e4... GameOverPre
		Application.LoadLevel (Application.loadedLevel);
		GameIsPaused = false;
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
}
