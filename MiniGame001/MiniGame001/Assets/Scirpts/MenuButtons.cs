using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MenuButtons : MonoBehaviour {
	public GameObject Button1;
	public GameObject Button2;
	void Update(){
		GameManager.gameHasEnded = false;
	}

	public void PlayGame ()
	{
		PauseMenu.GameIsPaused = false;
		Lives.miss = 3;
		ScoringSystem.score = 0;
		GameManager.gameHasEnded=false;
		Application.LoadLevel ("Sequence 1");
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
	public void Mute(){
		AudioListener.pause = !AudioListener.pause;
	}
	public void MoneySupport(){
		Application.LoadLevel ("Sequence 2");
	}
	public void MoneyWeb(){
		Application.OpenURL ("https://www.google.com");
	}
}
