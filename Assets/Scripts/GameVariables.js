#pragma strict

public static class GameVariables {
	var allowedTime : int = 90;
	var currentTime : int = GameVariables.allowedTime;
	var coins : int = 0;
	var maxCoins : int = GameObject.Find("Pieces").transform.childCount;
	var neededCoins : int = GameVariables.maxCoins - GameObject.Find("FaussesPieces").transform.childCount;
}