using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {
	public float speed;
	public float speedStoreWall;
	public float limitX;
	public float AddSpeed;
	public float delayAddSpeed;

	public bool berjalan;

	void Start(){
		speedStoreWall = speed;
		if (berjalan) {
			StartCoroutine (addBackgroundSpeed ());
		}
	}

	void Update(){
		if (berjalan) {
			transform.position += new Vector3 (speed * Time.deltaTime, 0f, 0f);
			if (transform.position.x <= limitX) {
				transform.position = new Vector3 (0f, -0.3f, -1f);
			}
		}
	}


	IEnumerator addBackgroundSpeed(){
		yield return new WaitForSeconds (delayAddSpeed);
		speed += AddSpeed;
		StartCoroutine (addBackgroundSpeed());
	}
}
