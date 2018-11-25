using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public static int Health;

	Text HealthValue;


	// Use this for initialization
	void Start () {
		HealthValue = GetComponent<Text>();

		Health = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if(Health < 0)
			Health = 0;
		HealthValue.text = " " + Health;
	}

	public static void AddHealth (int HealthToAdd) {

		Health += HealthToAdd;
		
	}
}
