using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlcomplete : MonoBehaviour {

	public void LoadNextLvl(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
