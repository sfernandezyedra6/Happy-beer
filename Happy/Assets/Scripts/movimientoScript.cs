using UnityEngine;
using System.Collections;

public class movimientoScript : MonoBehaviour {


	public int vhorizontal = 1;
	public int vvertical = 1;
	Vector3 movimiento;
	Vector3 posicionRaton;
	// Update is called once per frame
	void Update () {


		//-moverlo en un espacio de tiempo

		var v = Input.GetAxis ("Vertical");

		var h = Input.GetAxis ("Horizontal");

		movimiento = new Vector3 (vhorizontal * h, vvertical * v, 0);

		transform.Translate(movimiento * Time.deltaTime);

	}
}
