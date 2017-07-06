using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject enemy;

	public void OnCollisionEnter(Collision col)
    {
        // If enemy hits the player, destroy self and take away points
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            PointsSystem.Instance.points -= 100;
            Destroy(gameObject);
        }
    }
}
