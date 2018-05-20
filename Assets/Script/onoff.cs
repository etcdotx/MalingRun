using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onoff : MonoBehaviour {
	public AudioSource b;
	public Button z;//ON
	public Button n;//OFF

	void Start () {
		b =	GameObject.Find ("BGMSound").GetComponent<AudioSource> ();
		z =	GameObject.Find ("ON").GetComponent<Button> ();
		n = GameObject.Find ("OFF").GetComponent<Button> ();

		if (b.mute == true) {
			z.gameObject.SetActive (false);
			n.gameObject.SetActive (true);
		} else {
			z.gameObject.SetActive (true);
			n.gameObject.SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {

	}
}
