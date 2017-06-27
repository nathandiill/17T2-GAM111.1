using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounciness : MonoBehaviour {

    public float thrust = 125;
    public Rigidbody rb;
    public Vector3 ForceDirection;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnCollisionEnter (Collision col)
    {
        Vector3 Forcetoapply = transform.TransformDirection(ForceDirection);
        col.rigidbody.AddForce(Forcetoapply * thrust, ForceMode.Impulse);
    }

    private void OnDrawGizmos()
    {
        Vector3 Forcetoapply = transform.TransformDirection(ForceDirection);
        Gizmos.DrawRay(transform.position, Forcetoapply);
    }
}
