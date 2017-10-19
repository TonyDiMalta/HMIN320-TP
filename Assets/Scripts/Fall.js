#pragma strict

function OnTriggerEnter(other : Collider) {
	if(other.gameObject.CompareTag("Player")) {
		SceneManagement.SceneManager.LoadScene(SceneManagement.SceneManager.GetActiveScene().name); // notre scène courante, càd "Scene2Interieur"
	} else {
		Destroy(other.gameObject);
	}
}