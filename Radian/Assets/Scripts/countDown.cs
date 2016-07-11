using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class countDown : MonoBehaviour
{
    public float countDownFloat;
    private Text countDownText;

    void Start ()
    {
        countDownText = GameObject.FindWithTag("countdown").GetComponent<Text>();
	}
	
	void Update ()
    {
        countDownFloat -= (Time.deltaTime * 1.5f);
        if (countDownFloat > 0)
        {
            countDownText.text = ((int)countDownFloat + 1).ToString();
        }
        else
        {
            SceneManager.LoadScene("GameplayScene");
        }
    }
}
