using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text currentScoreText;

    public Text GameOverScoreText;
    public GameObject GAMEOVER_MENU;
    public float ratePoints = 10;
    public float scorePoints;
    //public GameObject biker = GameObject.Find("Motorcycle_Animation_v02");

    void Awake()
    {
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
    }
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        scorePoints += ratePoints * Time.deltaTime;
		GameOverScoreText.text = "" + Mathf.Round(scorePoints);
		currentScoreText.text = " Score: " + GameOverScoreText.text;
        //currentScoreText.text = " Score: " + Mathf.Round(scorePoints);
        //GameOverScoreText.text = currentScoreText.text;
        if (GAMEOVER_MENU.activeSelf)
        {
            SetHighScore();
        }
    }

    void DisplayScore()
    {
        currentScoreText.text = " Score: " + scorePoints;
    }

    void SetHighScore()
    {
        if (scorePoints > PlayerPrefs.GetInt("HighScore"))
           {
            PlayerPrefs.SetInt("HighScore", (int) scorePoints);

        }

    }
}
