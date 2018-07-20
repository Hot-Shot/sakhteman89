using UnityEngine;

public class GameManager : MonoBehaviour {
	bool gameHasEnded = false;
	public void EndGame()

	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			Invoke("Restart", 1f);
		}
	}
	public void  Restart()
	{
		ScoringSystem.score = 0;
		Application.LoadLevel ("Sequence 1");
	}
	
}
