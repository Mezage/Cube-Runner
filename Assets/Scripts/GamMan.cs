using UnityEngine;
using UnityEngine.SceneManagement;

public class GamMan : MonoBehaviour {
	bool gameEnded = false;
	public float Rdelay = 1f;
	public GameObject clUI;
	
	public void completedLevel() {
		clUI.SetActive(true);
	}
	
	public void GameOver (){
		
		if (gameEnded == false){
			gameEnded = true;
			Debug.Log("Game Over!");
			Invoke("Restart", Rdelay);
		}
	}
	
	void Restart (){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
