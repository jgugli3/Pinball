using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ball;

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == ball && Input.GetKey(KeyCode.Space))
        {
            ball.GetComponent<Rigidbody2D>().velocity = Vector3.up * 10.0f;
        }
    }
}
