using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanciSpawner : MonoBehaviour {
	public Rigidbody2D Rb;
	public float speed;
	public float delayAddSpeed;
	public float AddSpeed;
	public float speedStore;
	public GameManager death;
	public float throwSpeedUp;
	public float throwSpeed;

    void Start () {
        Rb = GetComponent <Rigidbody2D>();
		StartCoroutine (addObstacleSpeed ());
		speedStore = speed;
        
    }

	void Update () {
        Move_Obstacles();
        if (gameObject.transform.position.x <= 8f && gameObject.transform.position.x >= 7f)
        {
            Rb.gravityScale = 8f;
            Rb.AddForce(Random.Range(4, 5) * Vector3.left, ForceMode2D.Impulse);
            Rb.AddForce(Random.Range(4, 6) * Vector3.up, ForceMode2D.Impulse);
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


	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			death.RestartGame ();
		} 
	}
    
}
