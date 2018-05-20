using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clicksound : MonoBehaviour {
	public static clicksound suara1;
	private int y;
	public float volume;
	public AudioSource x;

	void Start () {
		if (suara1== null) {
			DontDestroyOnLoad (gameObject);
			suara1= this;
		} else if (suara1= this) {
			Destroy (gameObject);
		}


	}

	void Update () {

		y = SceneManager.GetActiveScene ().buildIndex;

		/*if (y == 1) {
			x.volume = 0f;
		} else {
			x.volume = 0.66f;
		}*/

	}
}
