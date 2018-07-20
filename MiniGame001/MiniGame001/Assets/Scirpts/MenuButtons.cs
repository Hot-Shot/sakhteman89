using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {

	public void PlayGame ()
	{
		Application.LoadLevel ("Sequence 1");
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
}
