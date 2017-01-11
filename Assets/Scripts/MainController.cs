using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainController : MonoBehaviour {
    public GameObject SpawnField;
    private GameObject[] obstacles;

    public GameObject healthy_prefab;
    public GameObject unhealthy1_prefab;
    public GameObject unhealthy2_prefab;
    public GameObject unhealthy3_prefab;
    public GameObject unhealthy4_prefab;
    public GameObject spider_prefab;

    // Use this for initialization
    void Start() {
        for (int i = 0; i < 20; i++) {
            spawnObjects(i);
        }
    }

    // Update is called once per frame
    void Update() {}

    void spawnObjects(int index) {
        Vector3 targetPosition = new Vector3(Random.Range(-35, 50),
            SpawnField.transform.position.y, Random.Range(-40, 48));

        if ((Physics2D.OverlapCircle(targetPosition, 5, 0, 0, 0)) == null) {
            if (index % 6 == 0)
                Instantiate(healthy_prefab, targetPosition, transform.rotation);
            else if (index % 6 == 1)
                Instantiate(unhealthy1_prefab, targetPosition, transform.rotation);
            else if (index % 6 == 2)
                Instantiate(unhealthy2_prefab, targetPosition, transform.rotation);
            else if (index % 6 == 3)
                Instantiate(unhealthy3_prefab, targetPosition, transform.rotation);
            else if (index % 6 == 4)
                Instantiate(unhealthy4_prefab, targetPosition, transform.rotation);
            else if (index % 6 == 5)
                Instantiate(spider_prefab, targetPosition, transform.rotation);
        } else {}
    }
}