using UnityEngine;
using System.Collections;


public class cloudMovement : MonoBehaviour
{
    public Vector3 cloudSpeed;
    public float cloudMoveLength;
    public float moveRightBy;
    private Vector3 cloudPos;

    void FixedUpdate()
    {
        cloudPos = new Vector3(Mathf.PingPong(Time.time * cloudMoveLength, moveRightBy), transform.position.y, 0);
        transform.position = cloudPos;
    }
}