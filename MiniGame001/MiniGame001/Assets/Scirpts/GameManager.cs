using UnityEngine;

public class GameManager : MonoBehaviour {
<<<<<<< HEAD
	public static bool gameHasEnded = false;
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
			ScoreUI.SetActive (false);
			LiveUI.SetActive (false);
			Pausebtn.SetActive (false);
			GameOverUI.SetActive(true);
=======
	bool gameHasEnded = false;
	public void EndGame()

	{
		if (gameHasEnded == false)
		{
>>>>>>> parent of 39ad3e4... GameOverPre
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			Invoke("Restart", 1f);
		}
	}
	public void  Restart()
	{
		GameManager.gameHasEnded = false;
		Lives.miss = 3;
		ScoringSystem.score = 0;
		Application.LoadLevel ("Sequence 1");
		gameHasEnded=false;
	}
	
}
