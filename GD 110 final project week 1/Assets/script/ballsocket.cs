using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider bluezone){

		if ( gameObject.tag == ("blue")){
			Debug.Log ("ball is in the blue");
		
		}
	}

}
