using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public static int score;
    public static Text text;

    // Use this for initialization
    void Start () {
    	score = 0;	
		text =  GameObject.Find ("Score").GetComponent<Text>();
    }
	
	// Update is called once per frame
	static void Update () {
		text.text = "Score: "+score;
    }

     public static int changeScore(int points) {
     	print(points);
         score += points;
         return score;
     }

}
