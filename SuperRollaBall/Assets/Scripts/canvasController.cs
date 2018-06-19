using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasController : MonoBehaviour {

    public Text scoreText;
    int score;
    public void IncreaseScore(int amount)
    {
        score += amount;
        //scoreText.text = "Score: " + score.ToString();
        //scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
    }

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
