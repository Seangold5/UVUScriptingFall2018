using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeSwitch : MonoBehaviour {

	public int Apples;
	public float Cloud;
	public string Colors;
	public int People;
	public float Fireworks;

	// Use this for initialization
	void Start () {

		switch(Apples){

			case 1:
				print("There is " + Apples + " apple!");
			break;

			case 5:
				print("There are " + Apples + " apples!");
			break;

			case 7:
				print("There are " + Apples + " apples!");
			break;

			case 15:
				print("There are " + Apples + " apples!");
			break;

			default:
				print("I can't eat " + Apples + " apples!");
			break;

		}
		switch(Cloud){

			case 1:
				print("The cloud is moving " + Cloud + " mph.");
			break;

			case 4:
				print("The cloud is moving " + Cloud + " mph.");
			break;

			case 10:
				print("The cloud is moving " + Cloud + " mph.");
			break;

			case 24:
				print("The cloud is moving " + Cloud + " mph.");
			break;

			case 55:
				print("The cloud is moving " + Cloud + " mph.");
			break;

			default:
				print("Tut tut! Looks like rain!");
			break;

		}
		switch(Colors){

			case Red:
				print("It is " + Colors);
			break;

			case Blue:
				print("It is " + Colors);
			break;

			case Yellow:
				print("It is " + Colors);
			break;

			case Green:
				print("It is " + Colors);
			break;

			default:
				print("I don't know " + Colors);
			break;


	}

}