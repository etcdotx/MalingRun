using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Destroyer : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "Obstacles") {
			Destroy (coll.gameObject);
		}
	}
}
