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
		CalcAdd(TotalVariable = VariableOne+VariableTwo);
	}

	// Other parts of script
	
	void Print () {
		TotalVariable;
	
	}

	}
