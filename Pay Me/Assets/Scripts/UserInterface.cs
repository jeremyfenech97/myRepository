using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserInterface : MonoBehaviour {

	// Use this for initialization

	int random =0;

	int current =0;
	string result ="";


	void Start () {
	System.Random rand = new System.Random ();
	random = rand.Next(1,99);

	}

	void OnGUI(){

		GUI.skin = amountLblSkin;
		Vector2 sizeAmountLbl = amountLblSkin.GetStyle("label").CalcSize(new GUIContent("Amount: "+random+"c"));
		GUI.Label(new Rect((Screen.width/2)-(sizeAmountLbl.x/2),50,sizeAmountLbl.x,sizeAmountLbl.y), "Amount: "+random+"c");
		GUI.Label(new Rect((Screen.width/2)-(sizeAmountLbl.x/2),100,sizeAmountLbl.x,sizeAmountLbl.y), "Current: " + current + "c");
		GUI.Label(new Rect((Screen.width/2)-(sizeAmountLbl.x/2),200,sizeAmountLbl.x,sizeAmountLbl.y), result);


		int height = Screen.height;
		if (GUI.Button(new Rect(110, height-130,100,100),""))

		{
			GetComponent<AudioSource> ().PlayOneShot (coinSound);
			current += 50;
			checkAmount();


		}
		if (GUI.Button(new Rect(220, height-130,100,100),""))

		{
			GetComponent<AudioSource> ().PlayOneShot (coinSound);
			current += 20; 
			checkAmount();
		}

		if (GUI.Button(new Rect(330, height-130,100,100),""))

		{
			GetComponent<AudioSource> ().PlayOneShot (coinSound);
			current += 10;  
			checkAmount();
		}
		if (GUI.Button(new Rect(440, height-130,100,100),""))

		{
			GetComponent<AudioSource> ().PlayOneShot (coinSound);
			current += 5;
			checkAmount();
		}
		if (GUI.Button(new Rect(550, height-130,100,100),""))
		{
			GetComponent<AudioSource> ().PlayOneShot (coinSound);
			current += 2;  
			checkAmount();
		}
		if (GUI.Button(new Rect(660, height-130,100,100),""))

		{
			GetComponent<AudioSource> ().PlayOneShot (coinSound);
			current += 1;
			checkAmount();
		}
	}

	void checkAmount()

	{

		if (current == random)

		{
			GetComponent<AudioSource> ().PlayOneShot (youwin);
			result = "You win!";

		}

		else if (current > random)

		{
			result = "you lose!";
		}
	}

	public GUISkin amountLblSkin;

	public AudioClip coinSound;
	public AudioClip youwin;
	void Update () {
		
	}
}
