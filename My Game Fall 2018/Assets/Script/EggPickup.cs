using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPickup : MonoBehaviour {
	
	public int AmoToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if(Other.GetComponent<Rigidbody2D> () == null)
			return;

		EggCount.AddAmo (AmoToAdd);

		Destroy (gameObject);
	}
}
