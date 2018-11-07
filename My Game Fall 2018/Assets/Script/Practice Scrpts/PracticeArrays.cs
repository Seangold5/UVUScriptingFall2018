using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArrays : MonoBehaviour {

	public int[] Popcorn = new int[18];
	public string[] Weapons;
	public string[] Plants;
	public string[] Animals;
	public int[] Money;

	// Use this for initialization
	void Start () {

		// Popcorn Array
		Popcorn[0] = 1;
		Popcorn[1] = 2;
		Popcorn[2] = 3;
		Popcorn[3] = 4;
		Popcorn[4] = 5;
		Popcorn[5] = 6;
		Popcorn[6] = 7;
		Popcorn[7] = 8;
		Popcorn[8] = 9;
		Popcorn[9] = 10;
		Popcorn[10] = 11;
		Popcorn[11] = 12;
		Popcorn[12] = 13;
		Popcorn[13] = 14;
		Popcorn[14] = 15;
		Popcorn[15] = 16;
		Popcorn[16] = 17;
		Popcorn[17] = 18;

		print(Popcorn[3]);

		// Weapon Array
		Weapons = new string[5];

		Weapons[0] = "Sword";
		Weapons[1] = "Lance";
		Weapons[2] = "Axe";
		Weapons[3] = "Bow";
		Weapons[4] = "Shield";

		foreach(string item in Weapons){
			print("You chose " + item);
		}

		// Plant Array
		Plants = new string[5];

		Plants[0] = "Tree";
		Plants[1] = "Bush";
		Plants[2] = "Algae";
		Plants[3] = "Moss";
		Plants[4] = "Shrubbery";

		foreach(string item in Plants){
			print("You found a " + item);
		}

		// Animal Array
		Animals = new string[5];

		Animals[0] = "Dog";
		Animals[1] = "Cat";
		Animals[2] = "Horse";
		Animals[3] = "Cow";
		Animals[4] = "Lizard";

		foreach(string item in Animals){
			print("You found a " + item);
		}

		// Money Array
		Money = new int[4];

		Money[0] = 1;
		Money[1] = 2;
		Money[2] = 3;
		Money[3] = 4;
		
	}
}
