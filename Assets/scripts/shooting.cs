using System.Collections;
using UnityEngine;

public class shooting : MonoBehaviour {

	public Rigidbody bullet_prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Camera cam = GameObject.Find ("CameraPlayer").GetComponent<Camera> ();

			Rigidbody theBullet;
			theBullet = Instantiate (bullet_prefab, cam.transform.position, cam.transform.rotation) as Rigidbody ;
			theBullet.AddForce (cam.transform.forward*5000);
		}	
	}
}
