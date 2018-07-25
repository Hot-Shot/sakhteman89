using UnityEngine;

public class GameManager : MonoBehaviour {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
	public static bool gameHasEnded = false;
=======
	bool gameHasEnded = false;
>>>>>>> parent of fd17175... GameOverDesigned
=======
	bool gameHasEnded = false;
>>>>>>> parent of fd17175... GameOverDesigned
	public GameObject GameOverUI;
	public GameObject spawner1;
	public GameObject spawner2;
	public GameObject spawner3;
	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			GameOverUI.SetActive(true);
=======
	bool gameHasEnded = false;
	public void EndGame()

	{
		if (gameHasEnded == false)
		{
>>>>>>> parent of 39ad3e4... GameOverPre
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
		ScoringSystem.score = 0;
		Application.LoadLevel ("Sequence 1");
<<<<<<< HEAD
=======
	}
	public void Menu(){
		Application.LoadLevel ("Sequence 0");
>>>>>>> parent of fd17175... GameOverDesigned
	}
	
}
