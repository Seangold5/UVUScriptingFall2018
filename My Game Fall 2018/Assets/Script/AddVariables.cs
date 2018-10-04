using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVariables : MonoBehaviour {

	// Variables
	public int VariableOne;
	public int VariableTwo;
	private int TotalVariable;

	// Use this for initialization
	void Start () {
		Add(TotalVariable = VariableOne+VariableTwo);
		
		Print(TotalVariable)
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
