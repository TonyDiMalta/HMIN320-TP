using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSound : MonoBehaviour {

	private GameObject[] music;

	void Start() {
		music = GameObject.FindGameObjectsWithTag("GameMusic");
		if(music.Length != 1) {
			Destroy(music[1]);
		}
	}

	void Awake() {
		DontDestroyOnLoad(this.gameObject);
	}
}