using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stargate : MonoBehaviour {
	public float distance = 10.0f;
	private GameObject player;

	void Start() {
		player = GameObject.FindWithTag("Player"); // pour trouver le personnage
	}

	void Update() {
		distance = Vector3.Distance(this.transform.position, player.transform.position);
		//Debug.Log("Distance is " + distance);
		if(distance < 1.5) {
			if(GameVariables.coins < GameVariables.neededCoins) {
				Debug.Log("More coins needed!");
			} else {
				Debug.Log("It is time!");
				SceneManager.LoadScene("Scene2Interieur");
			}
		}
	}
}