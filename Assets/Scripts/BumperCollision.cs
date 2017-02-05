using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperCollision : MonoBehaviour
{
    public GameObject ball;
    public GameObject scoreText;

	void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == ball)
        {
            scoreText.GetComponent<Score>().score = scoreText.GetComponent<Score>().score + 250;
        }
    }
}
