using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WizardGate : MonoBehaviour {
	GameObject cubes;
	bool hidden = true;

	void Start() {
		cubes = GameObject.Find("Cubes");
	}

	void Update() {
		if(hidden && cubes.transform.childCount == 1) {
			GetComponent<Collider>().isTrigger = true;
			hidden = false;
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Player") {
			Destroy(GameObject.FindGameObjectWithTag("GameMusic"));
			SceneManager.LoadScene("GameScene");
		}
	}
}
