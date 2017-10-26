using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject prefabObj;
	public float minX = -15f; //adaptez aux dimensions de votre scène !
	public float maxX = 15f;
	public float minZ = -15f;
	public float maxZ = 15f;
	public float t = 0.5f; // temps d’attente entre la création d’une sphère et la suivante
	public float y = 10f; // position Y des sphères (hauteur)

	void spawn() {
		Vector3 randomPos = new Vector3(Random.Range(minX, maxX), y, Random.Range(minZ, maxZ));
		GameObject newObj = Instantiate(prefabObj, randomPos, Quaternion.identity);
		newObj.transform.parent = GameObject.Find("GameObjectControl").transform;
	}

	void Start() {
		InvokeRepeating("spawn", 0, t);
	}

	void Update() {
		
	}
}