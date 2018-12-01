using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlEscenaSingle : MonoBehaviour {

	// Use this for initialization
	public void CargarEscena(string escena){
		SceneManager.LoadScene (escena);
	}// fin de cargarescena
}
