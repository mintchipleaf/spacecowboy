using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
 	
	public Vector2 speed = new Vector2(10,0);

	private Vector2 movement;

	// Update is called once per frames
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
	}
	void FixedUpdate () {
		rigidbody2D.velocity = movement;
		//rigidbody2D.AddForce(Vector2.up);
	}
}
	