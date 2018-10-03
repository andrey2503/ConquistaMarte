using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMovement : MonoBehaviour {
	public GameObject target; //Public variable to store a reference to the player game object
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
			PlayerController.instance.SpeedMovement ().y > 3f ||
			PlayerController.instance.SpeedMovement ().y < -3f ||
			PlayerController.instance.SpeedMovement ().x > 3f ||
			PlayerController.instance.SpeedMovement ().x < -3f) {
			//Debug.Log ("alejando");
			if(this.GetComponent<Camera> ().orthographicSize < 15f)
				this.GetComponent<Camera> ().orthographicSize =this.GetComponent<Camera> ().orthographicSize + 0.5f * speedSmoothMovementCamera *Time.deltaTime;
		} else {
			//Debug.Log ("Acercando");
			if(this.GetComponent<Camera> ().orthographicSize > 10f){
				this.GetComponent<Camera> ().orthographicSize = this.GetComponent<Camera> ().orthographicSize -0.5f * speedSmoothMovementCamera * Time.deltaTime;
			}
				
		}
	}


}