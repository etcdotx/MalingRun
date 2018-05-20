using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour {
	public float speed;
	public float speedStoreBackground;
	public float limitX;
	public float AddSpeed;
	public float delayAddSpeed;

	public bool jalan;

	void Start(){
		speedStoreBackground = speed;
		if (jalan) {
			StartCoroutine (addBackgroundSpeed ());
		}
	}

	void Update(){
		if (jalan) {
			transform.position += new Vector3 (speed * Time.deltaTime, 0f, 0f);
			if (transform.position.x <= limitX) {
				transform.position = new Vector3 (0f, 1.24f, 0f);
			}
		}
	}


	IEnumerator addBackgroundSpeed(){
		yield return new WaitForSeconds (delayAddSpeed);
		speed += AddSpeed;
		StartCoroutine (addBackgroundSpeed());
	}
}
