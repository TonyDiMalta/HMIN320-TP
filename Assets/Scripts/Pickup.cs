using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {
	private GameObject worldObject;
	private AudioSource audioSrc;

	void Start() {
		worldObject = GameObject.Find("World");
		audioSrc = gameObject.GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other) {
		if(this.transform.parent == GameObject.Find("Pieces").transform) {
			worldObject.SendMessage("AddCoin");
		} else {
			worldObject.SendMessage("DelCoin");
		}
		GetComponent<Renderer>().enabled = false;
		GetComponent<Collider>().enabled = false;
		if(audioSrc) {
			audioSrc.Play();
		}
	    Destroy(this.gameObject, 1f);
	}
}