using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float speed = 5f;

	void Update () {
		Vector3 pos = transform.position;

		if (Input.GetKey ("w")) {
			pos.y += speed * Time.deltaTime;
		}
		if (Input.GetKey ("s")) {
			pos.y -= speed * Time.deltaTime;
		}
		if (Input.GetKey ("d")) {
			pos.x += speed * Time.deltaTime;
		}
		if (Input.GetKey ("a")) {
			pos.x -= speed * Time.deltaTime;
		}


		transform.position = pos;
	
}
}