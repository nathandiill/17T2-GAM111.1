using UnityEngine;
using System.Collections;

public class SimplePlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float torqueScale = 1;
    public Vector3 previousTorque;
    public Vector3 ForceDirection;
    public float thrust;
    public float jumpCooldown = 0;
    public float jumpInterval = 2;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
    {
        var inputRot = Camera.main.transform.rotation;
        var tmp = inputRot.eulerAngles;
        tmp.x = 0;
        tmp.z = 0;
        inputRot = Quaternion.Euler(tmp);

        var torqueDir = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal")).normalized;
        torqueDir = inputRot * torqueDir;

        previousTorque = torqueDir * torqueScale;

        rb.AddTorque(previousTorque);

        Debug.DrawRay(transform.position, previousTorque, Color.red);

        if(Input.GetKeyDown("space") && jumpCooldown <= 0)
        {
            jumpCooldown = jumpInterval;

            Vector3 Forcetoapply = transform.TransformDirection(ForceDirection);
            GetComponent<Rigidbody>().AddForce(Forcetoapply * thrust, ForceMode.Impulse);
        }
    }

    void Update()
    {
        if (jumpCooldown > 0)
        {
            jumpCooldown -= Time.deltaTime;
        }
    }
}
