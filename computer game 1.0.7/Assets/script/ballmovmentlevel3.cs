﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovmentlevel3 : MonoBehaviour {

	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		if (Input.GetKey(KeyCode.Space))
			rb.velocity = new Vector3(30, 30, 30);

	}
}
