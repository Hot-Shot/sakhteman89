using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {
	public float PosX;
	public Vector2 PosiX;
	public GameObject Bird;

	void FixedUpdate () 
	{
		//We Get The X Position And Put it in PosX
		PosX = transform.position.x;
		//We Start Moving The Bird When the Position is Lower Than 7
		if (PosX <= 7f)
		{
			transform.Translate (0.02f, 0, 0);
		}
		//if We The Bird Gets to 7 in X Position It Will Delete The Object And Spawn It Again
		else if(PosX>=7f)
		{
			PosiX = new Vector2 (-4.52f, 4.29f);
			Instantiate (Bird, PosiX, Quaternion.identity);
			Destroy(gameObject);
		}
	
	}
}
