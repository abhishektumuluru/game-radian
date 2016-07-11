using UnityEngine;
using System.Collections;


public class backgroundMovement : MonoBehaviour
{
    public Vector3 bgSpeed;
    public float bgMoveLength;
    public float bgMoveRightBy;
    private Vector3 bgPos;

    void FixedUpdate()
    {
        bgPos = new Vector3(Mathf.PingPong(Time.time * bgMoveLength, bgMoveRightBy), transform.position.y, 0);
        transform.position = bgPos;
    }
}