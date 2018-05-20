using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacles")
        {
            col.gameObject.transform.position = new Vector3(0f, 8f, 0f); 
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "KillBox")
        {
            collision.gameObject.transform.position = new Vector3(0f, 9.5f, 0f);
        }
    }
}
