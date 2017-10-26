using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour {
	public bool collided;

	void OnCollisionEnter(Collision collision) {
		if(!collided) {
			collided = true;
			Animator personnageAnimator = gameObject.GetComponent<Animator>();
			personnageAnimator.SetTrigger("hitTrigger");
		}
	}
}
