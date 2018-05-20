using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickPlay : MonoBehaviour {
	public Button a;
	public AudioSource Z;
	// Use this for initialization
	void Start () {
		Z = GameObject.Find ("Click Sound").GetComponent<AudioSource> ();
		a = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		a.onClick.AddListener (plays);
	}

	void plays(){
		Z.Play ();
	}
}
