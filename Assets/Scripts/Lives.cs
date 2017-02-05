using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public GameObject loseText;
    public GameObject ball;
    public int lives;
    Vector3 stillDead;

	void Start ()
    {
        lives = 3;
        stillDead.x = 1000;
        stillDead.y = -10000;
        stillDead.z = 0;
	}
	
	void Update ()
    {
        gameObject.GetComponent<TextMesh>().text = "Lives: " + lives;
        
        if(lives == 0)
        {
            loseText.GetComponent<TextMesh>().color = Color.black;
            ball.gameObject.GetComponent<Transform>().position = stillDead;
        }
	}
}
