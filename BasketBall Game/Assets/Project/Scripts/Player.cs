﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public GameObject ball;
	public GameObject playerCamera;

	public float ballDistance=2f;
	public float ballthrowingDistance = 5f;

	public bool holdingBall=true;

	// Use this for initialization
	void Start () 
	{
		ball.GetComponent<Rigidbody> ().useGravity = false;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (holdingBall) 
		{
			
			ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;

			if (Input.GetMouseButton (0))
			{
				holdingBall = false;
				ball.GetComponent<Rigidbody> ().useGravity = true;
				ball.GetComponent<Rigidbody> ().AddForce (playerCamera.transform.forward*ballthrowingDistance);

			}
		}
	
	}
}
