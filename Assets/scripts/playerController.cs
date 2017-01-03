using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float upDownRange = 30.0f;
	float rotY = 0;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
		void Update () {
		//Rotation
		float rotX = Input.GetAxis("Mouse X");
		transform.Rotate (0, rotX, 0);

		rotY -= Input.GetAxis("Mouse Y");
		rotY = Mathf.Clamp (rotY, -upDownRange, upDownRange);
		GameObject.Find ("CameraPlayer").GetComponent<Camera>().transform.localRotation = Quaternion.Euler (rotY, 0, 0);


		//Movement
		float forwardSpeed = Input.GetAxis("Vertical")/1.5f;
		float sideSpeed = Input.GetAxis("Horizontal")/1.5f;
		Vector3 speed = new Vector3(sideSpeed,0,forwardSpeed);
		speed = transform.rotation * speed;
		CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);
	}
}
 