using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasterEgg : MonoBehaviour {
	private Text hitsText;
	private GameObject canvasObj;
	private Transform child;
	private int hits;
	private int maxHits;

	void Start() {
		canvasObj = GameObject.Find("Canvas");
		child = canvasObj.transform.Find("lblHits");
		hitsText = child.GetComponent<Text>();
		hits = 0;
		maxHits = 3;
		UpdateTxt();
	}

	public void GetHitted() {
		hits++;
		UpdateTxt();
	}

	void UpdateTxt() {
		hitsText.text = "Hits : " + hits;
		if(hits == maxHits) {
			SceneManager.LoadScene("Scene2Interieur");
		}
	}
}
