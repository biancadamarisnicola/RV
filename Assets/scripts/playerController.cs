using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
		void Update () {
		//Rotation
		float rotX = Input.GetAxis("Mouse X");
		transform.Rotate (0, rotX, 0);
		//Movement
		float forwardSpeed = Input.GetAxis("Vertical")/2.0f;
		float sideSpeed = Input.GetAxis("Horizontal")/2.0f;
		Vector3 speed = new Vector3(sideSpeed,0,forwardSpeed);
		CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);
	}
}
 