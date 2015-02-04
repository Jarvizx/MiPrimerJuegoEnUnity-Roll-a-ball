using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GUIText marcador;
	private int contador;
	public int cantidadDeCubosPuntos;

	void Start(){
		contador = 0;
		cantidadDeCubosPuntos = GameObject.FindGameObjectsWithTag("Puntos").Length;
	}

	void FixedUpdate () {
		float moveH = Input.GetAxis("Horizontal");
		float moveV = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveH, 0.0f, moveV);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Puntos"){

			other.gameObject.SetActive(false);
			contador = contador + 1;
			MostrarMensajes("Puntos: " + contador + " de " + cantidadDeCubosPuntos);

			if(contador >= cantidadDeCubosPuntos){
				MostrarMensajes("Recogiste todos los cubos, eres un campeon");
			}
		}
	}

	void MostrarMensajes(string mensaje){
		marcador.text = mensaje;
	}
}