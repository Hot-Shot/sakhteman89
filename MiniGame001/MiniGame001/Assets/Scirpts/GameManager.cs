using UnityEngine;
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
	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			FinalScore.text = "Final Score:" + "" + ScoringSystem.score;
			ScoreUI.SetActive (false);
			LiveUI.SetActive (false);
			Pausebtn.SetActive (false);
			GameOverUI.SetActive(true);
			gameHasEnded = true;
			spawner1.SetActive(false);
			spawner2.SetActive(false);
			spawner3.SetActive(false);
		}
	}
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
