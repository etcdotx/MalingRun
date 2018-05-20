using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectManager : MonoBehaviour {

	public int maxPlatforms = 30;
	public GameObject Platform;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;
	public float speed;
	public float limitX;
	public float AddSpeed;
	public float delayAddSpeed;

	private Vector2 originPosition;

	void Start(){
		originPosition = transform.position;
		StartCoroutine (addBackgroundSpeed ());
		Spawn ();
	}

	void Spawn(){
		for (int i = 0; i < maxPlatforms; i++) {
			Vector2 randomPosition = originPosition + new Vector2(Random.Range (horizontalMin,horizontalMax), Random.Range (verticalMin, verticalMax));
				Instantiate(Platform,randomPosition,Quaternion.identity);
				originPosition = randomPosition;
		}
	}

	void Update(){
		transform.position += new Vector3 (speed * Time.deltaTime, 0f, 0f);
	}


	IEnumerator addBackgroundSpeed(){
		yield return new WaitForSeconds (delayAddSpeed);
		speed += AddSpeed;
		StartCoroutine (addBackgroundSpeed());
	}
}
