﻿using System.Collections;
using UnityEngine;

public class enemyDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Enemy Car") {

			Destroy (col.gameObject);
		}
	}
}