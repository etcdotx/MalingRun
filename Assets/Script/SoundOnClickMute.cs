using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnClickMute : MonoBehaviour {
	public Button a;
	public AudioSource x;
	public AudioSource Z;
	
	void Start () {
		x = GameObject.Find ("BGMSound").GetComponent<AudioSource> ();
		Z = GameObject.Find ("Click Sound").GetComponent<AudioSource> ();
		a = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		a.onClick.AddListener (OFF);
	}

	void OFF(){
		x.mute = true;
		Z.mute = true;
	}
}
