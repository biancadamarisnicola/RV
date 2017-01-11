using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;

public class MainCollision : MonoBehaviour {
    // Use this for initialization
    void Start() {
    print(this.gameObject.tag);}

    // Update is called once per frame
    void Update() {}

    void OnCollisionEnter(UnityEngine.Collision otherObj) {
        if (otherObj.gameObject.CompareTag(Constants.SPIDER_TAG)) {
            ScoreController.changeScore(Constants.BULLET_COLLISION_SPIDER_POINTS);
        }
        else if (otherObj.gameObject.CompareTag(Constants.HEALTHY_TAG)) {
            ScoreController.changeScore(Constants.BULLET_COLLISION_HEALTHY_POINTS);
        }
        else if (otherObj.gameObject.CompareTag(Constants.UNHEALTHY_TAG)) {
            ScoreController.changeScore(Constants.BULLET_COLLISION_UNHEALTHY_POINTS);
        }
    }
}