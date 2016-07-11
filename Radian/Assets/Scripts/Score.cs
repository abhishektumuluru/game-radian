using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public static int score;
    public static int highScore;
    private Text scoreCounter;

	void Start ()
    {
        Debug.Log("Has fallen: " + ObsLooper.hasFallen);
		score = playerMovement.isDead? Score.score: 0;
        scoreCounter = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("highScore"); 
	}
	
	void Update ()
    {
        scoreCounter.text = score.ToString();
	}
}