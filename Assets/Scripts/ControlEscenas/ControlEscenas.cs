using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscenas : MonoBehaviour {
	public int escena=1;
	public void CargarEscena(){
		SceneManager.LoadScene (escena);
	}// fin de cargarescena

}
