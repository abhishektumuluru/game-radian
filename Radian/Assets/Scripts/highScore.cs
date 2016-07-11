using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class highScore : MonoBehaviour
{
    private Text hScoreTextView;

    void Start()
    {
        hScoreTextView = GetComponent<Text>();
    }

    void Update()
    {
        hScoreTextView.text = Score.highScore.ToString();
    }
}