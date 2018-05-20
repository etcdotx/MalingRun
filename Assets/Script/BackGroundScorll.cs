﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackGroundScorll : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSizeX;

	private Vector3 startPosition;

	void Start ()
	{
		startPosition = transform.position;
	}

	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
		transform.position = startPosition + Vector3.left * newPosition;

	}
}