using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighSchool : MonoBehaviour {
    public Text currentHighScore;

    // Use this for initialization
    void Start () {
        currentHighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
	
	// Update is called once per frame
	void Update () {
        currentHighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
