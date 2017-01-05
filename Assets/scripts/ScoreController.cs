using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

    public static int score = 0;
    public GUIText scoreText;

    private Camera cam;

    // Use this for initialization
    void Start () {
        cam = GameObject.Find("CameraPlayer").GetComponent<Camera>();
        scoreText.text = score.ToString();
        scoreText.transform.Translate(cam.transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();
//        scoreText.transform.Translate(cam.transform.right);
    }

    public static int changeScore(int points) {
        score += points;
        return score;
    }

}
