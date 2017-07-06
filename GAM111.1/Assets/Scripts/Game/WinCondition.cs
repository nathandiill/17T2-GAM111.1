using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {

    public float playerScore = PointsSystem.Instance.points;
    public float previousHighscore = PointsSystem.Instance.highScore;
    public float newPlayerScore;

    public WinCondition(float playerScore)
    {
        this.playerScore = playerScore;
    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void OnTriggerEnter(Collider col)
    {
        playerScore = newPlayerScore;

        if (newPlayerScore > previousHighscore)
        {
            previousHighscore = newPlayerScore;
            PlayerPrefs.SetFloat("High Score", previousHighscore);
            Debug.Log("Working");
        }
        SceneManager.LoadScene(5);
    }

}
