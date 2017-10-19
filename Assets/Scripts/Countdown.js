#pragma strict

private var timerText : UI.Text;
private var canvasObj : GameObject;
private var child : Transform;

function Start () {
	canvasObj = GameObject.Find("Canvas");
	child = canvasObj.transform.Find("lblTime");
	timerText = child.GetComponent(UI.Text);
	InvokeRepeating("TimerTick", 0, 1f);
}

function TimerTick() {
	if(GameVariables.currentTime > 0) {
		GameVariables.currentTime--;
		timerText.text = "Time : " + GameVariables.currentTime.ToString();
	} else {
		// game over and restart
		SceneManagement.SceneManager.LoadScene("Scene1Exterieur");
	}
}

function CancelTimer() {
	CancelInvoke("TimerTick");
}