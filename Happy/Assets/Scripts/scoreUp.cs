using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreUp : MonoBehaviour {

	private Text texto;
	private Text textoFinal;


	void Start () {

		texto = GameObject.Find ("textScore").GetComponent<Text>();
		textoFinal = GameObject.Find ("textoFinal").GetComponent<Text> ();
	}
	void OnTriggerEnter2D(Collider2D col){
		GameControl.score = GameControl.score + 1;
		//Debug.Log (GameControl.score);
		
			texto.text  = "Level " + GameControl.score.ToString ();
		textoFinal.text = texto.text;
	}

}