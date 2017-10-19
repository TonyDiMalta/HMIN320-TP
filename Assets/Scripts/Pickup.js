#pragma strict

private var worldObject : GameObject;
private var audioSrc : AudioSource;

function Start() {
	worldObject = GameObject.Find("World");
	audioSrc = gameObject.GetComponent.<AudioSource>();
}

function OnTriggerEnter(other : Collider) {
	if(this.transform.parent == GameObject.Find("Pieces").transform) {
		worldObject.SendMessage("AddCoin");
	} else {
		worldObject.SendMessage("DelCoin");
	}
	GetComponent.<Renderer>().enabled = false;
	GetComponent.<Collider>().enabled = false;
	if(audioSrc) {
		audioSrc.Play();
	}
    Destroy(this.gameObject, 1f);
}
