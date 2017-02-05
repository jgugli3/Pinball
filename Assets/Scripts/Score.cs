using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public int score;

	void Start ()
    {
        score = 0;
	}
	
	void Update ()
    {
        this.gameObject.GetComponent<TextMesh>().text = "Score: " + score.ToString();
	}
}
