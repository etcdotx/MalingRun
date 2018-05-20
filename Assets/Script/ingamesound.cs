using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingamesound : MonoBehaviour {
	public AudioSource A;//BGM
	public AudioSource B;//SFX
	// Use this for initialization
	void Start () {
		A = GameObject.Find ("BGMSound").GetComponent <AudioSource>();
		B = GameObject.Find ("ingamesound").GetComponent <AudioSource>();

		if (A.mute == true) {
			B.mute = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
