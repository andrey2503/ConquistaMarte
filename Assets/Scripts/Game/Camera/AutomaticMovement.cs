using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMovement : MonoBehaviour {
	public GameObject target; //Public variable to store a reference to the player game object
	private Rigidbody targetRB;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	public bool perspective = false;
	// Use this for initialization
	void Start () { }

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 desirePosition = target.transform.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desirePosition, smoothSpeed);
		transform.position = smoothedPosition;
		if (perspective)
			transform.LookAt (target.transform);
	}
}