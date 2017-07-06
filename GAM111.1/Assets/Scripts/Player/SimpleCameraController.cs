using UnityEngine;
using System.Collections;

public class SimpleCameraController : MonoBehaviour 
{
    public GameObject Player;
    public Vector3 Offset;
    public Vector3 FallOffset;
    public CameraMode cameraMode;
    public Vector3 OffsetAngles;
    public Vector3 FallingAngles;

    public enum CameraMode
    {
        Default,
        Falling
    }

    void LateUpdate () 
    {
        if (cameraMode == CameraMode.Falling)
        {
            // If player is falling, apply the falling camera position
            transform.position = Player.transform.position + FallOffset;
            transform.rotation = Quaternion.Euler(FallingAngles);
        }
        else
        {
            // If the player is in default, apply the default camera position
            transform.position = Player.transform.position + Offset;
            transform.rotation = Quaternion.Euler(OffsetAngles);
        }      
    }
}
