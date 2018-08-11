using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DecreaseScore : MonoBehaviour {
	public GameObject H1;
	public GameObject H2;
	public GameObject H3;
	public Animator Death;
	public Text Hit = null;
	void update(){
		if (Lives.miss == 2) 
		{
			H1.SetActive(true);
		}
		if (Lives.miss == 1)
		{
			H2.SetActive(true);
		}
		if (Lives.miss == 0) {
			H3.SetActive (true);
		}
	
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
