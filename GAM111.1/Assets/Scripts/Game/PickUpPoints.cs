﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoints : MonoBehaviour {

    public GameObject pickUp;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void OnCollisionEnter (Collision other)
    {
        PointsSystem.Instance.points += 50;

        Destroy(gameObject);
    }
}
