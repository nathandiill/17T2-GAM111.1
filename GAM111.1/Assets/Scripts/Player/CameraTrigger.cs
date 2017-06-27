using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public SimpleCameraController.CameraMode modeToSetTo;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Camera.main.GetComponent<SimpleCameraController>().cameraMode = modeToSetTo;
        }
    }
}
