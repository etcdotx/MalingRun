using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce;
	private AudioSource jump;
	public AudioClip jump2;
	private Rigidbody2D myRigidBody;
	public GameManager theGameManager;
	public bool IsGrounded = false;

	public LayerMask jumpAble;

	void Awake(){
		jump = GetComponent<AudioSource>();

	}
	void Start () {
		myRigidBody = GetComponent <Rigidbody2D> ();
	}

	void Update () 
	{
		Collider2D ray = Physics2D.OverlapCircle((Vector2)gameObject.transform.position - Vector2.up * 0.4f, 1f, jumpAble);
		if (ray != null && myRigidBody.velocity.y < 0.05f) {
			IsGrounded = true;
		}
		if ((Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) && IsGrounded == true) {
			myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, jumpForce);
			IsGrounded = false;
			jump.PlayOneShot (jump2);
		}
	} 

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "KillBox") {
			theGameManager.RestartGame ();
		}
	}
}
