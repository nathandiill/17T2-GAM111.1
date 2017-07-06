using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject enemy;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void OnCollisionEnter(Collision col)
    {
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            PointsSystem.Instance.points -= 100;
            Destroy(gameObject);
        }
    }
}
