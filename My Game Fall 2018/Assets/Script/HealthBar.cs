using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public static int Health;

	Image HealthImage;


	// Use this for initialization
	void Start () {
		HealthImage = GetComponent<Image>();

		Health = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if(Health < 0)
			Health = 0;
		HealthImage.image = " " + Health;
	}

	public static void AddHealth (int HealthToAdd) {

		Health += HealthToAdd;
		
	}
}
