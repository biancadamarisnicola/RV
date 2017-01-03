using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class playerController : MonoBehaviour {

	public float upDownRange = 30.0f;
	public float rotY = 0;
	public float verticalVelocity =0;
	public float jumpSpeed = 20.0f;
	CharacterController cc;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController cc = GetComponent<CharacterController>();

		//Rotation
		float rotX = Input.GetAxis("Mouse X");
		transform.Rotate (0, rotX, 0);

		rotY -= Input.GetAxis("Mouse Y");
		rotY = Mathf.Clamp (rotY, -upDownRange, upDownRange);
		GameObject.Find ("CameraPlayer").GetComponent<Camera>().transform.localRotation = Quaternion.Euler (rotY, 0, 0);

		//Movement
		float forwardSpeed = Input.GetAxis("Vertical")/1.5f;
		float sideSpeed = Input.GetAxis("Horizontal")/1.5f;

		verticalVelocity += Physics.gravity.y * Time.deltaTime;

		//cc.isGrounded - to check if out player is at the ground

		if ( Input.GetButtonDown ("Jump")) {
			verticalVelocity = 5.0f;
		};
			
		Vector3 speed = new Vector3(sideSpeed,verticalVelocity,forwardSpeed);
		speed = transform.rotation * speed;

		cc.Move(speed*Time.deltaTime);
	}
}
 