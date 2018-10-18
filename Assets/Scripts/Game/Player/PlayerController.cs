﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1000.0f;
	Rigidbody m_Rigidbody;
	public static PlayerController instance;
	public Vector3 speedMovementValue;

	public bool buttonLeftPressed = false;
	public bool buttonRightPressed = false;

	public ParticleSystem particle;

	void Awake () {
		if (PlayerController.instance == null) {
			PlayerController.instance = this;
		} else {
			Destroy (this.gameObject);
		}
	} // end to awake

	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody> ();
		particle.startSpeed = 0f;
	}

	// Update is called once per frame
	void FixedUpdate () {
		// Make it move 10 meters per second instead of 10 meters per frame...
		float translation = Input.GetAxis ("Horizontal") * speed;
		float translationUp = Input.GetAxis ("Vertical") * speed;

		if (translation != 0f || translationUp != 0f) {
			translation *= Time.deltaTime;
			translationUp *= Time.deltaTime;
			Vector3 v3 = new Vector3 (translation, translationUp, 0);
			m_Rigidbody.AddForce (v3);
			controlParticles (6f, translation > 0, translation < 0);
		} else {
			controlParticles (0f, false, false);
		}
		speedMovementValue = m_Rigidbody.velocity;
		checkButtonsActions ();
	}

	private void checkButtonsActions () {
		if (buttonLeftPressed || buttonRightPressed) {
			float translation = 1.1f * Time.deltaTime * speed;
			if (buttonLeftPressed && buttonRightPressed) {
				Vector3 v3 = new Vector3 (0, translation, 0);
				m_Rigidbody.AddForce (v3);
			} else if (buttonLeftPressed) {
				Vector3 v3 = new Vector3 (-translation, 0, 0);
				m_Rigidbody.AddForce (v3);
			} else if (buttonRightPressed) {
				Vector3 v3 = new Vector3 (translation, 0, 0);
				m_Rigidbody.AddForce (v3);
			}
		}
	}

	private void controlParticles (float speed, bool left, bool right) {
		particle.startSpeed = speed;
		if (left) {
			var x = particle.shape;
			x.rotation = new Vector3 (0, -90, 0); // solve my problem
			x.position = new Vector3 (-1, 0, -0.65f);
		} else if (right) {
			var x = particle.shape;
			x.rotation = new Vector3 (0, 90, 0); // solve my problem
			x.position = new Vector3 (1, 0, -0.65f);
		} else {
			var x = particle.shape;
			x.rotation = new Vector3 (0, 0, 0); // solve my problem
			x.position = new Vector3 (0, 0, 0);
		}
	}

	public Vector3 SpeedMovement () {
		return speedMovementValue;
	} // end to SpeedMovement
}