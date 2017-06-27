using UnityEngine;
using System.Collections;

public class SimpleCameraController : MonoBehaviour 
{
    public GameObject Player;
    public Vector3 Offset;
    public Vector3 FallOffset;
    //public Vector3 CameraRotate;
    public CameraMode cameraMode;
    public Vector3 OffsetAngles;
    public Vector3 FallingAngles;

    public enum CameraMode
    {
        Default,
        Falling
    }

	void Start ()
    {
        // Set the offset to the player position
        // Offset = transform.position - Player.transform.position;	
	}

    void LateUpdate () 
    {
        if (cameraMode == CameraMode.Falling)
        {
            transform.position = Player.transform.position + FallOffset;
            transform.rotation = Quaternion.Euler(FallingAngles);
        }
        else
        {
            transform.position = Player.transform.position + Offset;
            transform.rotation = Quaternion.Euler(OffsetAngles);
        }

        
    }
}
