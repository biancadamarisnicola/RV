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
        if (otherObj.gameObject.CompareTag(Constants.SPIDER_TAG)) {
            ScoreController.changeScore(Constants.BULLET_COLLISION_SPIDER_POINTS);
            shouldDestroyOther = true;
        }
        else if (otherObj.gameObject.CompareTag(Constants.HEALTHY_TAG)) {
            ScoreController.changeScore(Constants.BULLET_COLLISION_HEALTHY_POINTS);
            shouldDestroyOther = true;
        }
        else if (otherObj.gameObject.CompareTag(Constants.UNHEALTHY_TAG)) {
            ScoreController.changeScore(Constants.BULLET_COLLISION_UNHEALTHY_POINTS);
            shouldDestroyOther = true;
        }
        if (shouldDestroyOther)
            Destroy(otherObj.gameObject);
        Destroy(gameObject, 1f);
    }
}