using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowdelay : MonoBehaviour {
	
		public float speed;
		public float delayAddSpeed;
		public float delayAddSpeedWow;
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
			StartCoroutine (addDelaySpeed ());
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

	IEnumerator addDelaySpeed(){
		yield return new WaitForSeconds (delayAddSpeedWow);
	}

}
