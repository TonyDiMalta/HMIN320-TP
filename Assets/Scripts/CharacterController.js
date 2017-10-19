#pragma strict

function Start () {
	
}

function Update () {
	var speed = 5.0; // déplacer l’objet 5 m par seconde
	var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
	var y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
	transform.Translate(x, y, 0);
}
