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
