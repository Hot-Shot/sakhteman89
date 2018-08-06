using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DecreaseScore : MonoBehaviour {

	public Animator Death;
	public Text Dec = null;
	public Text Hit = null;
	void update(){
		bool Dead = false;
	
	}
	void start(){
	}
	public void OnMouseDown(){

		Death.SetBool ("Active", true);
		ScoringSystem.score -= 300;
		Lives.miss -= 1;
		Dec.text = "Score: " + ScoringSystem.score;
		Hit.text = "Lives: " + "" + Lives.miss;
		GetComponent<BoxCollider2D> ().enabled = false;
	}
}
