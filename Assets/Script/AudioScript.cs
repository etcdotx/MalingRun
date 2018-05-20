using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
	public bool descrease;
	public AudioSource game2;
	void Start(){

	}

	void Update () {
		if (descrease) {
			game2.volume = 0.3f;
		} else {
			game2.volume = 1f;
		}

	}
}
