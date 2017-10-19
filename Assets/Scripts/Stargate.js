#pragma strict

public var distance = 10.0;
private var player : GameObject;

function Start() {
	player = GameObject.FindWithTag("Player"); // pour trouver le personnage
}

function Update() {
	distance = Vector3.Distance(this.transform.position, player.transform.position);
	Debug.Log("Distance is " + distance);
	if(distance < 1.5) {
		if(GameVariables.coins < GameVariables.neededCoins) {
			Debug.Log("More coins needed!");
		} else {
			Debug.Log("It is time!");
			SceneManagement.SceneManager.LoadScene("Scene2Interieur");
		}
	}
}