using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class World : MonoBehaviour {
	private Text coinsText;
	private GameObject canvasObj;
	private Transform child;

	void Start() {
		canvasObj = GameObject.Find("Canvas");
		child = canvasObj.transform.Find("lblCoins");
		coinsText = child.GetComponent<Text>();
		UpdateTxt();
	}

	void AddCoin() {
		GameVariables.coins++;
		UpdateTxt();
	}

	void DelCoin() {
		GameVariables.coins--;
		UpdateTxt();
	}

	void UpdateTxt() {
		if(GameVariables.coins != GameVariables.maxCoins) {
			coinsText.text = "Score : " + GameVariables.coins;
		} else {
			coinsText.text = "Score : MAX(" + GameVariables.coins + ")";
		}
	}
}