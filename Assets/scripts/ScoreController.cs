using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public static int score;
    private Text scoreText;

    // Use this for initialization
    void Start () {
    	score = 0;	
        scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update () {
		scoreText.text = "Score: "+score;
    }

     public static int changeScore(int points) {
        score += points;
         if (score < 0) score = 0;
        return score;
     }

}
