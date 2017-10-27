using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Smash : MonoBehaviour {
	AudioSource audioSource;
	public float force = 1;

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.CompareTag("Player")) {
			Debug.Log("Impact = " + collision.relativeVelocity.y);
			//if((collision.impulse / Time.fixedDeltaTime).magnitude > force) {
			if(collision.relativeVelocity.y > force) {
				StartCoroutine(PlayAndRestart());
			}
		}
	}

	IEnumerator PlayAndRestart() {
		audioSource.Play();
		yield return new WaitForSeconds(audioSource.clip.length);
		SceneManager.LoadScene("Scene2Interieur");
	}
}
