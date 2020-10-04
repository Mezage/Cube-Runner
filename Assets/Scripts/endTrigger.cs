using UnityEngine;

public class endTrigger : MonoBehaviour {
	public GamMan gM;

	
	void OnTriggerEnter (){
		gM.completedLevel();
	}
}
