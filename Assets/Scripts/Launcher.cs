using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ball;
    public GameObject scoreText;
    public bool firstLaunch;

    void Start()
    {
        firstLaunch = true;
    }

	void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject == ball && Input.GetKey(KeyCode.Space))
        {
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * 25.0f;
            if (firstLaunch == true)
            {
                firstLaunch = false;
            }
            else
            {
                scoreText.GetComponent<Score>().score = scoreText.GetComponent<Score>().score + 500;
            }
        }
    }
}
