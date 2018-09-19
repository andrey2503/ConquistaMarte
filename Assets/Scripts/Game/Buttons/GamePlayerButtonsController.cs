using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerButtonsController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void activateLeftButton () {
		PlayerController.instance.buttonLeftPressed = true;
	}

	public void deactivateLeftButton () {
		PlayerController.instance.buttonLeftPressed = false;
	}

	public void activateRightButton () {
		PlayerController.instance.buttonRightPressed = true;
	}

	public void deactivateRightButton () {
		PlayerController.instance.buttonRightPressed = false;
	}
}