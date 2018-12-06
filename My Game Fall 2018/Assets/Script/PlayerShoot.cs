using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;
	public int AmmoUse;
	public Animator animator;
	

	// Use this for initialization
	void Start () {
			Projectile = Resources.Load("PreFab/Launching Egg") as GameObject;
			animator.SetBool("isAttacking", false);
	}
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyDown(KeyCode.Return) && EggCount.Ammo > 0){
				Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
				EggCount.AddAmmo(-AmmoUse);
				animator.SetBool("isAttacking", true);
			}
			else if(Input.GetKeyUp(KeyCode.Return)){
				animator.SetBool("isAttacking", false);
			}
	}
}
