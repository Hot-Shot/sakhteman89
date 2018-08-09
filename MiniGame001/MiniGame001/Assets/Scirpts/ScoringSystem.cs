using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoringSystem : MonoBehaviour {
	public Animator Death;
	public static int score=0;
	public Text scores = null;
	public void OnMouseDown() {
		Death.SetBool ("Active", true);
		score += 100;
		scores.text = "Score: " + score;
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (gameObject, 15);
	}
}
