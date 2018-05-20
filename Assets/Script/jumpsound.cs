using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpsound : MonoBehaviour {
	public AudioSource X;//BGM
	public AudioSource Y;//Lompat

	void Start () {
		X=GameObject.Find ("BGMSound").GetComponent <AudioSource>();
		Y = GameObject.Find ("Maling").GetComponent<AudioSource> ();
		if (X.mute == true) {
			Y.mute = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
