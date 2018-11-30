using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(goHome());
    }

    // Update is called once per frame
    private IEnumerator goHome() {
		yield return new WaitForSeconds (50);
		SceneManager.LoadScene ("Pantalla1");
	}
}
