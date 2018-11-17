using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlVida : MonoBehaviour {
	public Text vida;
	int cantidadVida=100;
	public Scrollbar barraVida;
	// Use this for initialization
	void Start () {
		vida.text= "" + cantidadVida;
		barraVida.size = cantidadVida;
	}
	
	void OnCollisionEnter(Collision cinfo){
		//Debug.Log (cinfo.relativeVelocity.magnitude);
		if(cinfo.relativeVelocity.magnitude >= 2){
			cantidadVida -= 5;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}//
		if(cinfo.relativeVelocity.magnitude > 3){
			cantidadVida -= 10;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cinfo.relativeVelocity.magnitude > 5){
			cantidadVida -= 20;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cinfo.relativeVelocity.magnitude > 7){
			cantidadVida -= 30;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cinfo.relativeVelocity.magnitude > 10){
			cantidadVida -= 50;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cantidadVida <= 0){
			ControlMenus.instance.gameOver ();
		}
	}// fin on collideer enter
}
