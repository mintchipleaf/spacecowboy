using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
 	
	public Vector2 speed = new Vector2(10,0);

	private Vector2 movement;

	// Update is called once per frames
	void Update () {
		float inputX = 0;
		float inputY = 0;

		if (Input.GetKey ("left")){
			inputX = -1;
		}
		if (Input.GetKey ("right")){
			inputX = 1;
		}
		

		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
	}
	void FixedUpdate () {
		rigidbody2D.velocity = movement;
		//rigidbody2D.AddForce(Vector2.up);
	}
}
	