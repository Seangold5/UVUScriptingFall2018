using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EggCount : MonoBehaviour {

	public static int Ammo;

	Text AmmoText;


	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Ammo < 0)
			Ammo = 0;
		else if(Ammo > 100)
			Ammo = 100;
		AmmoText.text = " " + Ammo;
	}

	public static void AddAmmo (int AmmoToAdd) {

		Ammo += AmmoToAdd;
		
	}
}