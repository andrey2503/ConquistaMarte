using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour {

	public float speed = 500.0f;
	private GameObject Rover;

	// Use this for initialization
	void Start () {
		Rover = GameObject.FindGameObjectWithTag("Rover");
	}

	// Update is called once per frame
	void FixedUpdate () {
		// Make it move 10 meters per second instead of 10 meters per frame...
		float rotation = Input.GetAxis ("Horizontal") * speed;

		if (rotation > 0) {
			rotation *= Time.deltaTime;
			// Rotate the object around its local X axis at 1 degree per second
			transform.Rotate (0.0f, -rotation, 0.0f, Space.Self);
			Rover.GetComponent<Rigidbody>().AddForce(((Vector3.right * rotation) / 2), ForceMode.Acceleration);
		} else if (rotation < 0) {
			rotation *= Time.deltaTime;
			// Rotate the object around its local X axis at 1 degree per second
			transform.Rotate (0.0f, -rotation, 0.0f, Space.Self);
			Rover.GetComponent<Rigidbody>().AddForce(((Vector3.left * -rotation) / 2), ForceMode.Acceleration);
		}
	}
}