using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name); // notre scène courante
		} else {
			Destroy(other.gameObject);
		}
	}
}