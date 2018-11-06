using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public CharacterMove Player;

	public bool IsFollowing;


	// Camera position off set
	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		Player = FindObjectOfType<CharacterMove>();

		IsFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(IsFollowing){
			transform.position = new Vector3(Player.transform.position.x + xOffset, Player.transform.position.y + yOffset, transform.position.z);
			
		}
	}
}
