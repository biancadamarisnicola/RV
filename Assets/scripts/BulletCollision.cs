using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;

public class BulletCollision : MonoBehaviour {
    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update() {}

    void OnCollisionEnter(UnityEngine.Collision otherObj) {
        bool shouldDestroyOther = false;
        Debug.Log("OnCollisionEnter");
        Debug.Log(otherObj.gameObject.tag);
        if (otherObj.gameObject.CompareTag(Constants.SPIDER_TAG)) {
            print("spider");
            ScoreController.changeScore(Constants.BULLET_COLLISION_SPIDER_POINTS);
            shouldDestroyOther = true;
        }
        else if (otherObj.gameObject.CompareTag(Constants.HEALTHY_TAG)) {
            print("healthy");
            ScoreController.changeScore(Constants.BULLET_COLLISION_HEALTHY_POINTS);
            shouldDestroyOther = true;
        }
        else if (otherObj.gameObject.CompareTag(Constants.UNHEALTHY_TAG)) {
             print("unhealthy");
            ScoreController.changeScore(Constants.BULLET_COLLISION_UNHEALTHY_POINTS);
            shouldDestroyOther = true;
        }
        if (shouldDestroyOther){
            print("shouldDestroyOther");
            Destroy(otherObj.gameObject);
        }
        Destroy(gameObject, 1f);
    }
}