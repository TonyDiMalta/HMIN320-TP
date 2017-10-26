using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkOnWater : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			GameObject.Find("Terrain").transform.tag = "Water";
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Player") {
			GameObject.Find("Terrain").transform.tag = "Untagged";
		}
	}
}