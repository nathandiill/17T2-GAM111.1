using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounciness : MonoBehaviour {

    public float thrust = 15;
    public Rigidbody rb;
    public Vector3 ForceDirection;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnCollisionEnter (Collision col)
    {
        // Set the direction and apply impulse force
        Vector3 Forcetoapply = transform.TransformDirection(ForceDirection);
        col.rigidbody.AddForce(Forcetoapply * thrust, ForceMode.Impulse);
        AudioManager.Instance.bounceWallAudio();
    }

    private void OnDrawGizmos()
    {
        // Draw gizmo for ease of use
        Vector3 Forcetoapply = transform.TransformDirection(ForceDirection);
        Gizmos.DrawRay(transform.position, Forcetoapply);
    }
}
