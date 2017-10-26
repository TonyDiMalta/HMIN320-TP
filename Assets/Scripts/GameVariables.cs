using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVariables {
	public static int allowedTime = 90;
	public static int currentTime = allowedTime;
	public static int coins = 0;
	public static int maxCoins = GameObject.Find("Pieces").transform.childCount;
	public static int neededCoins = maxCoins - GameObject.Find("FaussesPieces").transform.childCount;
	public static bool swordGrabbed = false;
}
