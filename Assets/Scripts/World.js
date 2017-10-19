#pragma strict

private var coinsText : UI.Text;
private var canvasObj : GameObject;
private var child : Transform;

function Start() {
	canvasObj = GameObject.Find("Canvas");
	child = canvasObj.transform.Find("lblCoins"); //le nom de votre objet UI Text
	coinsText = child.GetComponent(UI.Text);
	UpdateTxt();
}

function AddCoin() {
	GameVariables.coins++;
	UpdateTxt();
}

function DelCoin() {
	GameVariables.coins--;
	UpdateTxt();
}

function UpdateTxt() {
	if(GameVariables.coins != GameVariables.maxCoins) {
		coinsText.text = "Score : " + GameVariables.coins;
	} else {
		coinsText.text = "Score : MAX(" + GameVariables.coins + ")";
	}
}