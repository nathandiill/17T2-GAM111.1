using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour {

    public Text highScore;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        highScore.text = string.Format("High Score: " + PlayerPrefs.GetFloat("High Score"));
	}
}
