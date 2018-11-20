using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscenas : MonoBehaviour {
	public string escena="Pantalla";
	public string escenaActual="Pantalla";
	public int tiempoEspera = 0;
	public static ControlEscenas instance;
	void Awake(){
		if(ControlEscenas.instance==null){
			ControlEscenas.instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}



	public void CargarEscena(){
		SceneManager.LoadScene (escena);
	}// fin de cargarescena

	private IEnumerator SceneSwitcher () {
		if(tiempoEspera != 0)
        yield return new WaitForSeconds (tiempoEspera);
		CargarEscena();
    }

	public void reiniciarNivel(){
		SceneManager.LoadScene (escenaActual);
	}//
}
