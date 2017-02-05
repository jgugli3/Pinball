using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failTrigger : MonoBehaviour
{
    public GameObject ball;
    public GameObject livesText;
    public GameObject launcher;
    Vector3 ballPos;

    void Start()
    {
        ballPos = ball.GetComponent<Transform>().position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == ball)
        {
            launcher.GetComponent<Launcher>().firstLaunch = true;
            Transform ballTransform = ball.GetComponent<Transform>();
            ballTransform.position = ballPos;
            livesText.GetComponent<Lives>().lives = livesText.GetComponent<Lives>().lives - 1;
        }
    }
}
