using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		float speed = 5.0f; // déplacer l’objet 5 m par seconde
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		transform.Translate(x, y, 0);
	}
}