using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene(5);
    }

}
