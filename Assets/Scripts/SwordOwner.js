#pragma strict

public var distance = 10.0;
private var worldObject : GameObject;
private var player : GameObject;
public var x = 0.42;
public var y = 0.66;
public var z = 0.48;
public var scalef = 5.0;
private var grabbed = false;

function Start() {
	worldObject = GameObject.Find("World");
	player = GameObject.FindWithTag("Player"); // pour trouver le personnage
}

function Update() {
	if(!grabbed) {
		distance = Vector3.Distance(this.transform.position, player.transform.position);
		Debug.Log("Distance is " + distance);
		if(distance < 1.3) {
			Debug.Log("Grab your destiny!");
			worldObject.SendMessage("CancelTimer");
			this.transform.parent = player.transform;
			this.transform.localScale -= new Vector3(scalef, scalef, scalef);
			this.transform.localPosition = new Vector3(x, y, z);
			this.transform.localRotation = Quaternion.identity;
			this.transform.localRotation = Quaternion.Euler(90, 0, -120);
			grabbed = true;
		}
	}
}