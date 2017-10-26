using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordOwner : MonoBehaviour {
	public float distance = 10.0f;
	private GameObject worldObject;
	private GameObject player;
	public float x = 0.42f;
	public float y = 0.66f;
	public float z = 0.42f;
	public float scalef = 8.0f;

	void Start() {
		worldObject = GameObject.Find("World");
		player = GameObject.FindWithTag("Player"); // pour trouver le personnage
		if(GameVariables.swordGrabbed) {
			GrabSword();
		}
	}

	void Update() {
		if(!GameVariables.swordGrabbed) {
			distance = Vector3.Distance(this.transform.position, player.transform.position);
			//Debug.Log("Distance is " + distance);
			if(distance < 1.3) {
				GrabSword();
			}
		}
	}

	void GrabSword() {
		Debug.Log("Grab your destiny!");
		worldObject.SendMessage("CancelTimer");
		this.transform.parent = player.transform;
		this.transform.localScale -= new Vector3(scalef, scalef, scalef);
		this.transform.localPosition = new Vector3(x, y, z);
		this.transform.localRotation = Quaternion.identity;
		this.transform.localRotation = Quaternion.Euler(90, 0, -120);
		GameVariables.swordGrabbed = true;
	}
}