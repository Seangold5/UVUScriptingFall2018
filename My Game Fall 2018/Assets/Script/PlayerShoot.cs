﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;

	// Use this for initialization
	void Start () {
			Projectile = GameObject.Find("Launching Egg");
	}
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyDown(KeyCode.Return))
				Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
				
	}
}