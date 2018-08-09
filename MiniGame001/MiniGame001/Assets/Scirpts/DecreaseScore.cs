using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DecreaseScore : MonoBehaviour {

	public Animator Death;
	public Text Hit = null;
	void update(){
	
	}
	void start(){
	}
	public void OnMouseDown(){

		Death.SetBool ("Active", true);
		Lives.miss -= 1;
		Hit.text = "Lives: " + "" + Lives.miss;
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (gameObject, 15);
	}
}
