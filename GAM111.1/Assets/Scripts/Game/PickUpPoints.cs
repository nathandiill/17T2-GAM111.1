using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoints : MonoBehaviour {

    public GameObject pickUp;

    public void OnCollisionEnter (Collision other)
    {
        // Add points and destroy self
        PointsSystem.Instance.points += 50;
        AudioManager.Instance.pointPickUpAudio();
        Destroy(gameObject);
    }
}
