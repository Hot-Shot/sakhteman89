using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DecreaseScore : MonoBehaviour {
	public Text Dec = null;
	public Text Hit = null;
	public void OnMouseDown(){
		ScoringSystem.score -= 300;
		Lives.miss -= 1;
		Dec.text = "Score: " + ScoringSystem.score;
		Hit.text = "Lives: " + "" + Lives.miss;
		Destroy (gameObject);
	}
}
