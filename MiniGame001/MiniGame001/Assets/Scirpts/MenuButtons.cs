﻿using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MenuButtons : MonoBehaviour {

	public void PlayGame ()
	{
		Application.LoadLevel ("Sequence 1");
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
	public void Mute(){
		AudioListener.pause = !AudioListener.pause;
	}
}
