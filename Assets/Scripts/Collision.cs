using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
	public movement plMov;
	
	void OnCollisionEnter (UnityEngine.Collision colInfo){
		if (colInfo.gameObject.tag == "Obstacle"){
			//Debug.Log("Hit obst!");
			plMov.enabled = false;
			
			FindObjectOfType<GamMan>().GameOver();
		}
		
	}
}
