using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {
	public float PosX;
	public Vector2 PosiX;
	public GameObject Bird;

	void Update () 
	{
		PosX = transform.position.x;
		if (PosX <= 5f)
		{
			transform.Translate (0.02f, 0, 0);
		}
		else if(PosX>=5f)
		{
			PosiX = new Vector2 (-4.52f, 4.29f);
			Instantiate (Bird, PosiX, Quaternion.identity);
			Destroy(gameObject);
		}
	
	}
}
