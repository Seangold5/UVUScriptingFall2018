using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EggCount : MonoBehaviour {

	public static int Amo;

	Text AmoText;


	// Use this for initialization
	void Start () {
		AmoText = GetComponent<Text>();

		Amo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Amo < 0)
			Amo = 0;
		else if(Amo > 100)
			Amo = 100;
		AmoText.text = " " + Amo;
	}

	public static void AddAmo (int AmoToAdd) {

		Amo += AmoToAdd;
		
	}
}