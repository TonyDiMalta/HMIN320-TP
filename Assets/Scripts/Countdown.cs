using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {
	private Text timerText;
	private GameObject canvasObj;
	private Transform child;

	void Start () {
		canvasObj = GameObject.Find("Canvas");
		child = canvasObj.transform.Find("lblTime");
		timerText = child.GetComponent<Text>();
		InvokeRepeating("TimerTick", 0, 1f);
	}

	void TimerTick() {
		if(GameVariables.currentTime > 0) {
			GameVariables.currentTime--;
			timerText.text = "Time : " + GameVariables.currentTime.ToString();
		} else {
			// game over and restart
			if(SceneManager.GetActiveScene().name.Equals("Scene2Interieur")) {
				Destroy(GameObject.FindGameObjectWithTag("GameMusic"));
			}
			GameVariables.currentTime = GameVariables.allowedTime;
			SceneManager.LoadScene("Scene1Exterieur");
		}
	}

	void CancelTimer() {
		CancelInvoke("TimerTick");
		timerText.text = "Time : " + GameVariables.currentTime.ToString();
	}
}