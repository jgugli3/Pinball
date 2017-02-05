using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failTrigger : MonoBehaviour
{
    public GameObject ball;
    Vector3 ballPos;

    void Start()
    {
        ballPos = ball.GetComponent<Transform>().position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == ball)
        {
            Transform ballTransform = ball.GetComponent<Transform>();
            ballTransform.position = ballPos;
        }

        //other.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
