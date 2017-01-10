using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject[] UnhealthyArray;
	public GameObject[] HealthyArray;
	public GameObject[] Spider;

	public int UnhealthyCount;
	public int HealthyCount;
	public int SpidersCount;


	// Use this for initialization
	void Start () {
		SpawnThings (UnhealthyCount,UnhealthyArray);
		SpawnThings (HealthyCount, HealthyArray);
		SpawnThings (SpidersCount, Spider);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SpawnThings(int Count,GameObject[] ObjectArray)
	{
		for (int i = 0; i < Count; i++) {
			Vector3 randPoz = new Vector3 (Random.Range (-4, 4), 0.3f, Random.Range (-4, 4));
			if ((Physics2D.OverlapCircle (randPoz, 5, 0, 0, 0)) == null) {
				GameObject child = Instantiate (ObjectArray [Random.Range (1, ObjectArray.Length)], randPoz, Quaternion.identity);
				child.transform.parent = transform;
			}
		}
	}
}
