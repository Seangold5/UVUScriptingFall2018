using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public static int Health;
	public Rigidbody2D PC;
	public GameObject Player;
	private bool IsDead = false;
	public GameObject GameOver;

	Text HealthValue;


	// Use this for initialization
	void Start () {
		HealthValue = GetComponent<Text>();
		Health = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if(Health < 0){
			Health = 0;
			IsDead = true;
			GameOver.SetActive(true);
			Player.gameObject.SetActive(false);
		}
			
		HealthValue.text = " " + Health;
	}

	public static void AddHealth (int HealthToAdd) {

		Health += HealthToAdd;
		
	}
}
