using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs2 : MonoBehaviour {
	public GameObject platform;
	public GameObject wall;
    public GameObject Window;
    public GameObject Pan;
	int count;
	void Start () {
	}

	void Update () {

	}

    void OnCollisionEnter2D(Collision2D col){
        count = Random.Range(1, 2000);
        if (count % 3 == 0)
        {
            Instantiate(platform, new Vector3(10.8f, Random.Range(-2f, 0f), 0), Quaternion.identity);
        }
        else if (count % 3 == 2)
        {
            Instantiate(wall, new Vector3(10.8f, -1.65f, 0), Quaternion.identity);
        }
        else if (count % 3 == 1)
        {
            Instantiate(Window, new Vector3(12f, 1f, 0), Quaternion.identity);
            Instantiate(Pan, new Vector3(12f, 1f, 0), Quaternion.identity);
        }
    }
}
