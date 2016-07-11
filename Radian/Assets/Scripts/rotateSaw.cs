using UnityEngine;
using System.Collections;

public class rotateSaw : MonoBehaviour
{
    private float randomAngle;
	public float shift;
	private Vector3 pos;

	void Start ()
    {
         randomAngle = Random.Range(-0.08f, 0.08f);
    }

	void FixedUpdate()
    {
		pos = transform.position;
		pos.x += shift;
        pos.x += randomAngle;
		transform.position = pos;
	}

}