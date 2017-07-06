using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsSystem : MonoBehaviour {

    public static PointsSystem Instance;

    void Awake()
    {
        Instance = this;
    }

    public float points = 2000;
    public float pointReduction = 5;
    public Text UIpoints;

    void Start ()
    {
        
    }
	
	void Update ()
    {
        points -= pointReduction * Time.deltaTime;

        UIpoints.text = string.Format("Points: " + points);
	}

    public float pointCalculator (float currentPoints)
    {
        return points;
    }
}
