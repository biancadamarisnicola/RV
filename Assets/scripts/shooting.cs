using System.Collections;
using UnityEngine;

public class shooting : MonoBehaviour {
    public GameObject bullet_prefab;
    public GameObject spider_prefab;


    public int noOfBulletsCreated = 0;

    public const string BULLET_TAG = "Bullet";
    public const string SPIDER_TAG = "Spider";
    public const int maxBulletDistance = 10;

    private Camera cam;

    // Use this for initialization
    void Start() {
        cam = GameObject.Find("CameraPlayer").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update() {
        GameObject[] bullets = GameObject.FindGameObjectsWithTag(BULLET_TAG);
        System.Console.WriteLine(bullets.Length);
        for (int i = 0; i < bullets.Length; i++) {
            // bullets[i].gameObject.transform.Translate(cam.transform.forward, Camera.main.transform);
        }

        if (Input.GetButtonDown("Fire1")) {
            GameObject theBullet;
            theBullet = Instantiate(bullet_prefab, cam.transform.position, cam.transform.rotation);
            theBullet.name = BULLET_TAG + noOfBulletsCreated;
            theBullet.gameObject.tag = BULLET_TAG;
            noOfBulletsCreated++;

            Vector3 bulletPosition = cam.transform.forward;
            theBullet.gameObject.transform.Translate(bulletPosition);
        }
    }
}