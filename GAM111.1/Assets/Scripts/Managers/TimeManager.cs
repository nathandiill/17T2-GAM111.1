using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour {

    public static TimeManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public float timeRemaining = 540;
    public float timeUnitDecrease = 1;
    public Text time;

	void Update ()
    {
        // Countdown time and display UI
        timeRemaining -= timeUnitDecrease * Time.deltaTime;
        time.text = string.Format("Time Remaining: " + timeRemaining);

        if (timeRemaining <= 0)
        {
            // If time runs out, load the lose scene
            SceneManager.LoadScene(4);
        }
    }
}
