using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayForPreston : MonoBehaviour {

	public string[] Pets = new string[5];

	// Use this for initialization
	void Start () {

		Pets[0] = "Fido";
		Pets[1] = "Bingo";
		Pets[2] = "Sparky";
		Pets[3] = "Buttons";
		Pets[4] = "Tingle";

		foreach(string item in Pets){
			print("You named your dog " + item);
		}

	}
}
