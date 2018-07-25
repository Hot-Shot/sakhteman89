using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lives : MonoBehaviour {
	public static int miss=3;
	public Text Lifes = null;
	void start() {
	}
	
	// Update is called once per frame
	void Update () {
		if (miss <= 0) 
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy") {

			miss-=1;
			Lifes.text = "Lives: "+""+ miss;
			Destroy (col.gameObject);
		} 
		else if (col.gameObject.tag == "Enemy2")
		{
			miss-=1;
			Lifes.text = "Lives: "+""+ miss;
			Destroy (col.gameObject);
		}
	}
}
