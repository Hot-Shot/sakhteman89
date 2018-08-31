using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lives : MonoBehaviour {
	public AudioClip Wrong;
	public AudioSource Wrong1;
	public static int miss=3;
	public Text Lifes = null;
	void start() {

	}
	
	// Update is called once per frame
	void Update () {
		Wrong1.clip = Wrong;
		if (miss <= 0) 
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			Wrong1.Play();
			miss-=1;
			Lifes.text = "Lives: "+""+ miss;
			Destroy (col.gameObject);
		} 
		else if (col.gameObject.tag == "Enemy2")
		{
				Wrong1.Play();
			miss-=1;
			Lifes.text = "Lives: "+""+ miss;
			Destroy (col.gameObject);
		}
	}
}
