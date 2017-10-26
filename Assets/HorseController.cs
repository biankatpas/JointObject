using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private float moveHorizontal;
	private float moveVertical;

	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{

		transform.Translate (speed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis ("Vertical") * Time.deltaTime);

		//moveVertical = Input.GetAxis ("Vertical");
		//moveHorizontal = Input.GetAxis ("Horizontal");
		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		//rb.AddForce (movement * speed);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Objetivo")) {
			other.gameObject.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Obstaculo")) {

			speed = speed - 10;

			//if (speed < 0) {
			//	speed = 0.01f;
			//}

			//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			//rb.AddForce (movement * speed);
			transform.Translate (speed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis ("Vertical") * Time.deltaTime);


		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
