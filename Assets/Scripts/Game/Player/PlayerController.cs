using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1000.0f;
	Rigidbody m_Rigidbody;

	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		// Make it move 10 meters per second instead of 10 meters per frame...
		float translation = Input.GetAxis ("Horizontal") * speed;
		float translationUp = Input.GetAxis ("Vertical") * speed;
		translation *= Time.deltaTime;
		translationUp *= Time.deltaTime;

		// Get the horizontal and vertical axis.
		// By default they are mapped to the arrow keys.
		// The value is in the range -1 to 1
		// float translation = Input.GetAxis ("Vertical") * speed;

		// Move translation along the object's z-axis
		// transform.Translate (translation, 0, 0);
		Vector3 v3 = new Vector3(translation, translationUp, 0); 
		m_Rigidbody.AddForce(v3);

		// transform.Translate (0, translationUp, 0);
	}
}