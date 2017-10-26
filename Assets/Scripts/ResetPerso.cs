using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPerso : MonoBehaviour {

	void ResetPersoOnHit() {
		GameObject world = GameObject.Find("World");
		world.SendMessage("GetHitted");
		gameObject.transform.localScale = new Vector3(80, 80, 80); //les valeurs initiales d’échelle
		gameObject.GetComponentInChildren<CollisionBehaviour>().collided = false;
	}
}
