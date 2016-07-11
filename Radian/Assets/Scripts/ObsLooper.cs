using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ObsLooper : MonoBehaviour
{
    private GameObject player;
    public static GameObject obstacle1;
    public static GameObject obstacle2;
    public static bool hasFallen = false;
    public AudioClip scoreSound;
	public static int numTimesPlayed = 0;
	public menuStateManager msm;

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        player = GameObject.FindWithTag("player");
        if (collider.isTrigger)
        {
			Vector3 pos = collider.transform.position;
			if (pos.x < 2.725)
            {
				pos.x = Random.Range (0.85f, 2.724f);
			} else
            {
				pos.x = Random.Range (2.726f, 4.6f);
			}
			pos.y = 4.2f;
			collider.transform.position = pos;
            if (!playerMovement.isDead)
            {
                Score.score++;
                AudioSource.PlayClipAtPoint(scoreSound, transform.position);
                if (Score.score >= Score.highScore)
                {
                    Score.highScore = Score.score;
                    PlayerPrefs.SetInt("highScore", Score.score);
                    PlayerPrefs.Save();
                }
            }
		}
        if (collider.tag == "player")
        {
            hasFallen = true;
            Destroy(player);
			numTimesPlayed++;
			msm.LoadScene("gameOverScene");

        }
	}
}