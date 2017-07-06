using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour {

    public Text highScore;
	
	void Update ()
    {
        // Retrieve and display highscore
        highScore.text = string.Format("High Score: " + PlayerPrefs.GetFloat("High Score"));
	}
}
