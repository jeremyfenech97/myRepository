﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gmaecode : MonoBehaviour {
	


	void Start () {
		
	}
	public void LoadLevel(string name)
	{
		print("Level Load requested for " + name);
		SceneManager.LoadScene (name);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
