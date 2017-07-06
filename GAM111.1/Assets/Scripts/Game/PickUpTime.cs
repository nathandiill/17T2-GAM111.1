using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTime : MonoBehaviour {

    public GameObject pickUp;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void OnCollisionEnter(Collision other)
    {
        TimeManager.Instance.timeRemaining += 20;

        Destroy(gameObject);
    }
}
