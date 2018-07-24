using UnityEngine;

public class GameManager : MonoBehaviour {
	bool gameHasEnded = false;
	public GameObject GameOverUI;
	public GameObject spawner1;
	public GameObject spawner2;
	public GameObject spawner3;
	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			GameOverUI.SetActive(true);
			gameHasEnded = true;
			spawner1.SetActive(false);
			spawner2.SetActive(false);
			spawner3.SetActive(false);
		}
	}
	public void Restart()
	{
		ScoringSystem.score = 0;
		Application.LoadLevel ("Sequence 1");
	}
	public void Menu(){
		Application.LoadLevel ("Sequence 0");
	}
}
