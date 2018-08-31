using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoringSystem : MonoBehaviour {
	public AudioClip Punch;
	public AudioSource Punch1;
	public Animator Death;
	public static int score=0;
	public Text scores = null;
	public Text HighScore = null;
	void Start(){
		Punch1.clip = Punch;
		HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}
	public void OnMouseDown() {
		if (PauseMenu.GameIsPaused||GameManager.gameHasEnded)
			return;
		Punch1.Play ();
		Death.SetBool ("Active", true);
		score += 100;
		scores.text =""+ score;
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (gameObject, 15);
		if (score > PlayerPrefs.GetInt ("HighScore", 0))
		{
			PlayerPrefs.SetInt ("HighScore", score);
			HighScore.text = score.ToString();
		}
	}
}
