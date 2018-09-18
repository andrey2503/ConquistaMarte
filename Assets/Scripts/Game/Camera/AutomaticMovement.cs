using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMovement : MonoBehaviour {
	public GameObject target; //Public variable to store a reference to the player game object
	private Rigidbody targetRB;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	public bool perspective = false;
	public float speedSmoothMovementCamera=2f;
	public static AutomaticMovement instance;
	void Awake(){
		if(AutomaticMovement.instance==null){
			AutomaticMovement.instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}// end to awake
	// Use this for initialization
	void Start () { }

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 desirePosition = target.transform.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desirePosition, smoothSpeed);
		transform.position = smoothedPosition;
		if (perspective) {
			transform.LookAt (target.transform);
		}
		checkVelocityPlayer ();

	}// end To fixedupdate

	public void checkVelocityPlayer(){
		
		if (
			PlayerController.instance.SpeedMovement ().y > 5 ||
			PlayerController.instance.SpeedMovement ().y < -5 ||
			PlayerController.instance.SpeedMovement ().x > 5 ||
			PlayerController.instance.SpeedMovement ().x < -5) {
			if(this.GetComponent<Camera> ().orthographicSize < 8f)
				this.GetComponent<Camera> ().orthographicSize =this.GetComponent<Camera> ().orthographicSize + 0.2f * speedSmoothMovementCamera *Time.deltaTime;
		} else {
			if(this.GetComponent<Camera> ().orthographicSize >= 5f){
				this.GetComponent<Camera> ().orthographicSize = this.GetComponent<Camera> ().orthographicSize -0.2f * speedSmoothMovementCamera * Time.deltaTime;
			}
				
		}
	}


}