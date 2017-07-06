using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTime : MonoBehaviour {

    public GameObject pickUp;

    public void OnCollisionEnter(Collision other)
    {
        // Add time and destroy self
        TimeManager.Instance.timeRemaining += 20;
        AudioManager.Instance.timePickUpAudio();
        Destroy(gameObject);
    }
}
