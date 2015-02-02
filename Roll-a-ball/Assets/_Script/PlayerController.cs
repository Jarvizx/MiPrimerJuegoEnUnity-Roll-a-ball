using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public string nombreJugador;
	
	void FixedUpdate () {
		float moveH = Input.GetAxis("Horizontal");
		float moveV = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveH, 0.0f, moveV);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Puntos"){
			other.gameObject.SetActive(false);
		}
	}
	
}