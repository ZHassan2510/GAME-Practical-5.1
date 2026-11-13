using UnityEngine;

public class CrawlerCamera : MonoBehaviour
{
    public Transform ball;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - ball.position;
        //distance bet camera and ball
    }

    void LateUpdate()
    {
        transform.position = ball.position + offset;
    }
}
