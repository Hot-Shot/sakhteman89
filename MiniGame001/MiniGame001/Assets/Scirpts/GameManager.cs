using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static bool gameHasEnded = false;
	public Text FinalScore = null;
	public GameObject GameOverUI;
	public GameObject ScoreUI;
	public GameObject LiveUI;
	public GameObject Pausebtn;
	public GameObject spawner1;
	public GameObject spawner2;
	public GameObject spawner3;
	/// <summary>
	/// sets ui for game ending
	/// </summary>
	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			FinalScore.text = ""+ScoringSystem.score;
			ScoreUI.SetActive (false);
			LiveUI.SetActive (false);
			Pausebtn.SetActive (false);
			GameOverUI.SetActive(true);
			gameHasEnded = true;

		}
	}



	/// <summary>
	/// restart the game vars
	/// </summary>
	public void Restart()
	{
		GameManager.gameHasEnded = false;
		Lives.miss = 3;
		ScoringSystem.score = 0;
		Application.LoadLevel ("Sequence 1");
		gameHasEnded=false;
	}
	public void Menu(){
		Application.LoadLevel ("Sequence 0");
	}
}
