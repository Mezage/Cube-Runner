using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform p1;
	public Vector3 offset;	//includes 3 values
	
	// Update is called once per frame
	void Update () {
		transform.position = p1.position + offset;
		
	}
}
