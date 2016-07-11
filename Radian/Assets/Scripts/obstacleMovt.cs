using UnityEngine;
using System.Collections;

public class obstacleMovt : MonoBehaviour
{
	public float downShift; 
	private Vector3 pos;
	private float multiplier;

	void FixedUpdate()
    {
		multiplier = Mathf.FloorToInt(Score.score/10);
		pos = transform.position;
		pos.y += downShift + (multiplier*-0.02f);
		transform.position = pos;
	}
}