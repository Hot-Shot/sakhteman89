using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoringSystem : MonoBehaviour {
	public static int score=0;
	public Text scores = null;

	public void OnMouseDown() {
		score += 100;
		scores.text = "Score: " + score;
		Destroy (gameObject);
	
	}
}
