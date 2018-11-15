using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;
	public int AmoUse;

	// Use this for initialization
	void Start () {
			Projectile = Resources.Load("PreFab/Launching Egg") as GameObject;
	}
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyDown(KeyCode.Return) && EggCount.Amo > 0){
				Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
				EggCount.AddAmo(-AmoUse);
			}
	}
}
