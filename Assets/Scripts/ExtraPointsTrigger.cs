using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPointsTrigger : MonoBehaviour
{
    public GameObject ball;
    public GameObject scoreText;
    Vector3 ballPos;

    void Start()
    {
        ballPos = ball.GetComponent<Transform>().position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == ball)
        {
            Transform ballTransform = ball.GetComponent<Transform>();
            ballTransform.position = ballPos;
            scoreText.GetComponent<Score>().score = scoreText.GetComponent<Score>().score + 500;
        }

        //other.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
