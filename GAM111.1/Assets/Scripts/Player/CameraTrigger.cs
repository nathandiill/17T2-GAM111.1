using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public SimpleCameraController.CameraMode modeToSetTo;

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            // If player hits trigger, switch camera modes on the enumerator
            Camera.main.GetComponent<SimpleCameraController>().cameraMode = modeToSetTo;
            AudioManager.Instance.nextLevelAudio();
        }
    }
}
