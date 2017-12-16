using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gmaecode : MonoBehaviour {

    public AudioClip backgroundmusic;

    void Start () {
        GetComponent<AudioSource>().PlayOneShot(backgroundmusic);
    }
	public void LoadLevel(string name)
	{
		print("Level Load requested for " + name);
		SceneManager.LoadScene (name);
	}
    public void quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
