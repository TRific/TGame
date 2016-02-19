using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text currentScoreText;
    public Text GameOverScoreText;
    public float ratePoints = 10;
    public float scorePoints;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        scorePoints += ratePoints * Time.deltaTime;
        currentScoreText.text = " Score: " + Mathf.Round(scorePoints);
        GameOverScoreText.text = currentScoreText.text;

    }

    void DisplayScore()
    {
        currentScoreText.text = " SCORE: " + scorePoints;
    }

}
