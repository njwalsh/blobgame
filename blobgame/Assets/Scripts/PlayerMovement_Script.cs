using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement_Script : MonoBehaviour {
	
	public List<GameObject> nodes = new List<GameObject>();
	
	private bool grounded = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Vector2 origin = new Vector2(this.transform.position.x, this.transform.position.y);
		Vector2 direction = -1 * Vector2.up;
		Debug.DrawRay(new Vector3(origin.x, origin.y, 0f), new Vector3(0f, origin.y - 5f, 0f), Color.red);
		if(Physics2D.Raycast(origin, direction, 5f)){//add separate layer mask for player colliders
			Debug.Log("collide");
		}
		
		if(Input.GetKey(KeyCode.RightArrow)){
			foreach(GameObject node in nodes){
				Vector2 moveForce = new Vector2(10f, 0f);
				node.rigidbody2D.AddForce(moveForce);
			}
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			foreach(GameObject node in nodes){
				Vector2 moveForce = new Vector2(-10f, 0f);
				node.rigidbody2D.AddForce(moveForce);
			}
		}
		if((Input.GetKey(KeyCode.UpArrow)) && (grounded == true)){
			
		}
	}
}
