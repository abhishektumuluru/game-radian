using UnityEngine;
using System.Collections;

public class mainMenuPlayer : MonoBehaviour
{
    float angle = 0;
    public float speed;
    public float circleScale;
    public static bool isMuted = false;

    void FixedUpdate()
    {   
        float x = Mathf.Cos(angle) * circleScale;
        float y = Mathf.Sin(angle) * circleScale;
        angle += Time.deltaTime * speed;
        transform.position = new Vector3(x, y);
    }
}