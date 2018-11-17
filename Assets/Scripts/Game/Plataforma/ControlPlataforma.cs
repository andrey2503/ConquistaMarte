using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlataforma : MonoBehaviour {
	public static ControlPlataforma instance;
	public int segundos;
	void Awake(){
		if(ControlPlataforma.instance==null){
			ControlPlataforma.instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}// fin de awake
		
	void OnCollisionEnter(Collision sinfo){
		//Debug.Log ("estado en el colision");
		Debug.Log (sinfo.gameObject.tag);
		StartCoroutine (cuentaPlataforma());
	}// fin de oncollioson stay

	IEnumerator cuentaPlataforma(){
		yield return new WaitForSeconds (1f);
		segundos++;
		Debug.Log (segundos);
		if (segundos >= 3) {
			Debug.Log ("fin del nivel");
			StopCoroutine (cuentaPlataforma ());
			ControlMenus.instance.gameWin ();
		} else {
			StartCoroutine (cuentaPlataforma());
		}

	}//

	void OnCollisionExit(Collision sinfo){
		segundos = 0;
		Debug.Log ("Salio");
		//Debug.Log (sinfo.gameObject.tag);
		StopCoroutine (cuentaPlataforma());
	}// fin de oncollioson stay

}// fin de la clase
