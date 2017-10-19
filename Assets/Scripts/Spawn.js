#pragma strict

public var prefabObj : GameObject;
public var minX = -15 ; //adaptez aux dimensions de votre scène !
public var maxX = 15;
public var minZ = -15 ;
public var maxZ = 15 ;
public var t = .5 ; // temps d’attente entre la création d’une sphère et la suivante
public var y = 10; // position Y des sphères (hauteur)

function spawn() {
	var randomPos = Vector3(Random.Range(minX, maxX), y, Random.Range(minZ, maxZ));
	var newObj = Instantiate(prefabObj, randomPos, Quaternion.identity);
	newObj.transform.parent = GameObject.Find("GameObjectControl").transform;
}

function Start () {
	InvokeRepeating("spawn", 0, t);
}

function Update () {
	
}
