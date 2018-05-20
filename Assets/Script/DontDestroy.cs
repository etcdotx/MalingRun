using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DontDestroy : MonoBehaviour {
	public static DontDestroy suara;
	private int y;
	public float volume;
	public AudioSource x;

	// Use this for initialization
	void Start () {
		x = GameObject.Find ("BGMSound").GetComponent<AudioSource> ();
		if (suara == null) {
			DontDestroyOnLoad (gameObject);
			suara = this;
		} else if (suara != this) {
			Destroy (gameObject);
		}


	}

	void Update () {
		
		y = SceneManager.GetActiveScene ().buildIndex;

		if (y == 0) {
			x.volume = 0.66f;
		} else {
			x.volume = 0f;
		}

	}
}
