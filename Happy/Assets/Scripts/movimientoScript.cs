using UnityEngine;
using System.Collections;

public class movimientoScript : MonoBehaviour {


	public float vhorizontal = 1;
	public float vvertical = 1;
	Vector3 movimiento;
	Vector3 posicionRaton;
	// Update is called once per frame
	void Update () {


		//-moverlo en un espacio de tiempo
		if (!GameControl.dead) {
						var v = Input.GetAxis ("Vertical");

						var h = Input.GetAxis ("Horizontal");
						if (h < 0) {
								transform.localScale = new Vector3 (-0.2564656f, 0.2564656f, 1);
						} else if (h > 0) {
								transform.localScale = new Vector3 (0.2564656f, 0.2564656f, 1);
						}

						movimiento = new Vector3 (vhorizontal * h, vvertical * v, 0);

						transform.Translate (movimiento * Time.deltaTime);
				}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(!GameControl.dead && col.transform.tag == "enemigo"){

			GameControl.dead = true;
			//AudioSource.PlayClipAtPoint(deadSound, transform.position);
			//anim.SetBool("dead",true);
			rigidbody2D.gravityScale = 4;
			transform.localScale = new Vector3 (0.2564656f, -0.2564656f, 0.2564656f);

		}
	}
}
