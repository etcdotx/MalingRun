using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdController : MonoBehaviour {
	
	public GoogleMobileAdsDemoScript admob;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
		admob.RequestBanner();
	}

}