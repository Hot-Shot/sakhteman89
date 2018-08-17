using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoringSystem : MonoBehaviour {
	public Animator Death;
	public static int score=0;
	public Text scores = null;
	public void OnMouseDown() {
		if (PauseMenu.GameIsPaused||GameManager.gameHasEnded)
			return;
		Death.SetBool ("Active", true);
		score += 100;
		scores.text =""+ score;
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (gameObject, 15);
	}
}
