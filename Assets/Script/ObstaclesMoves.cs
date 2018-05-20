using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMoves : MonoBehaviour {
	public float speed;
	public float delayAddSpeed;
	public float AddSpeed;
	public float speedStore;
	int itung =0;
	public bool gerak;

	void Start () {
		StartCoroutine (addObstacleSpeed ());
		speedStore = speed;
	}

	void Update () {
		if (gerak) {
			Move_Obstacles();
		}
	}
		

	void Move_Obstacles(){
		transform.Translate (-speed*Time.deltaTime, 0, 0);
	}

	IEnumerator addObstacleSpeed(){
		yield return new WaitForSeconds (delayAddSpeed);
		speed += AddSpeed;
		StartCoroutine (addObstacleSpeed());
	}

}
