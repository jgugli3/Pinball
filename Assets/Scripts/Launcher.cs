using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ball;

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == ball)
        {
            if(Input.GetKey(KeyCode.Space))
            {

            }
        }
    }
}
