using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainController : MonoBehaviour {


    public GameObject SpawnField;
    private GameObject[] obstacles;

    public GameObject healthy_prefab;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 20; i++) {
            
            spawnObjects(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void spawnObjects( int x) {

        Vector3 targetPosition = new Vector3(SpawnField.transform.position.x + Random.Range(-15, 15), SpawnField.transform.position.y, SpawnField.transform.position.z + Random.Range(-20, 20));

        if ((Physics2D.OverlapCircle(targetPosition, 5, 0, 0, 0)) == null) {
            Instantiate(healthy_prefab, targetPosition, transform.rotation);
        } else { }
    }



}
