using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
