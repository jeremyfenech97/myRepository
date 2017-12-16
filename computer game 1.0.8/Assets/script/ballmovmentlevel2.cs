using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovmentlevel2 : MonoBehaviour {

	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		if (Input.GetKey(KeyCode.Space))
			rb.velocity = new Vector3(20, 20, 20);

	}
}
