using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenus : MonoBehaviour {
	public GameObject gameover;
	public GameObject gamepause;
	// Use this for initialization
	public static ControlMenus instance;
	void Awake(){
		if(ControlMenus.instance==null){
			ControlMenus.instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}

	public void reiniciarNivel(){
		ControlEscenas.instance.CargarEscena ();
	}// fin de reiniciarNivel

	public void pausarJuego(){
		gamepause.SetActive (true);
	}//

	public void gameOver(){
		gameover.SetActive (true);	
	}//

}
