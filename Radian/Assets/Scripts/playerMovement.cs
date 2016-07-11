using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    float angle = 0;
    float timeElapsed = 0;
    public float speed;
    public float circleScale;
    public static int tapCount = 0;
    public static bool isDead = false;
    private Animator death;
    public AudioClip playerTap;
    public AudioClip obstacleHit;
    private bool soundPlay = true;

	void Start () {
        death = GetComponentInChildren<Animator>();
    }

    void Update()
    {
		//if (Input.touches.Length > 0 && !PauseMenu.isPaused) {
			//if (Input.touches [0].phase == TouchPhase.Ended) {
		if (Input.anyKeyDown && !PauseMenu.isPaused) {
				tapCount += 1;
				AudioSource.PlayClipAtPoint (playerTap, transform.position);
			}
        //}   
    }
    void FixedUpdate()
    {
        if (!isDead)
        {
            timeElapsed += Time.deltaTime;

            float x = Mathf.Cos(angle) * circleScale;
            float y = Mathf.Sin(angle) * circleScale;
            if (tapCount % 2 == 0)
            {
				angle += Time.deltaTime * speed;
                transform.position = new Vector3(x, y);
            }
            else
            {
				angle -= Time.deltaTime * speed ;
                transform.position = new Vector3(x, y);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        if (soundPlay)
        {
            AudioSource.PlayClipAtPoint(obstacleHit, transform.position);
            soundPlay = false;
        }
        death.SetTrigger("playerDeath");
        GetComponent<Rigidbody2D>().gravityScale = 2;
    }
}