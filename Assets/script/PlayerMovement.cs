
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// We mark this as "Fixed" Update because we
    // are using it to mess with physics.
	void FixedUpdate () 
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime,0 ,0, ForceMode.VelocityChange);
            //Only executed if condiditon is met
        }

        if (rb.position.y < - 1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}
}