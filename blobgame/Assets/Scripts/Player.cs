using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    //VARIABLES
    public float force = 20;
    public float floatHeight = 10;
    public float liftForce = 500;
    public float damping = 5;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //rigidbody2D.AddForce(Vector2.right);
        float xInput = Input.GetAxisRaw("Horizontal");
        
        if (xInput < 0)
        {
            rigidbody2D.AddForce(Vector2.right * xInput * force);
        }
        else if (xInput > 0)
        {
            rigidbody2D.AddForce(Vector2.right * xInput * force);
        }
        
        Debug.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y-2.5f, 0), Color.green);
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null) 
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            float heightError = floatHeight - distance;
            float force = liftForce * heightError - rigidbody2D.velocity.y * damping;
            rigidbody2D.AddForce(Vector3.up * force);
        }

        Debug.Log(rigidbody2D.velocity);
	}
}
