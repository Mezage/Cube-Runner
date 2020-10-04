using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	
	public Rigidbody rigbod;
	public float fforce = 2000f;
	public float sideF = 500f;
	
	// Use this for initialization
	/* void Start () {
		//to toggle gravity
		//rigbod.useGravity = false; 
			
	} */
	
	// Update is called once per frame
	//unity likes fixed update better when usinf unity physics
	void FixedUpdate () {
		rigbod.AddForce(0, 0, fforce * Time.deltaTime);	//compensate for different fps on cp's
	
		//user inputs
		if (Input.GetKey("d")){
			rigbod.AddForce(sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}if (Input.GetKey("a")){
			rigbod.AddForce(-sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		
		if (rigbod.position.y < -1f){
			FindObjectOfType<GamMan>().GameOver();
		}
	
	}
	
}
