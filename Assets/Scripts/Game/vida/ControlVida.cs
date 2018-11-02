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
		if(cinfo.relativeVelocity.magnitude > 5){
			cantidadVida -= 5;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}//
		if(cinfo.relativeVelocity.magnitude > 15){
			cantidadVida -= 5;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cinfo.relativeVelocity.magnitude > 25){
			cantidadVida -= 5;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cinfo.relativeVelocity.magnitude > 35){
			cantidadVida -= 5;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cinfo.relativeVelocity.magnitude > 50){
			cantidadVida -= 5;
			vida.text= "" + cantidadVida;
			barraVida.size = cantidadVida/100f;

		}// 
		if(cantidadVida <= 0){
			ControlMenus.instance.gameOver ();
		}
	}// fin on collideer enter
}
