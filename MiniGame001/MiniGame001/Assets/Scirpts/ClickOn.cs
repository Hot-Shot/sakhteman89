using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class ClickOn : MonoBehaviour {
	public Button MusicButton;
	public Sprite SoundOn;
	public Sprite Mute;
	private int counter=0;

	// Use this for initialization
	void Start () {
		MusicButton = GetComponent<Button>();
	
	}
	public void ChangeButton(){
		counter++;
		if (counter % 2 == 0) {
			MusicButton.image.overrideSprite = SoundOn;
		} else {
			MusicButton.image.overrideSprite = Mute;
		}
	}
}
