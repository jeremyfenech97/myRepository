using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gmaecode : MonoBehaviour {

    public AudioClip backgroundmusic;
    public Text p1;
    public Text p2;
    public Text fs;

    int p2count;
    int p1count;
    string score;
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(backgroundmusic);
        p1count = 0;
        p2count = 0;
        p1.text = "P1:" + p1count.ToString();
        p2.text = "P2:" + p2count.ToString();
        fs.text = "The Winer is :" + score;

    }
    void scorefinalScore()
    {

        if(p1count > p2count)
        {
            score = "p1";
        }
        else
        {
            score = "p2";
        }
    }

     void load()
    {
        if(p1count == 5) { SceneManager.LoadScene("level_2"); }
            
        if (p2count == 5) { SceneManager.LoadScene("level_2"); }

        if (p1count == 10) { SceneManager.LoadScene("level_3"); }

        if (p2count == 10) { SceneManager.LoadScene("level_3"); }

        if (p1count == 15) { SceneManager.LoadScene("Score_sceen"); }


        if (p2count == 15) { SceneManager.LoadScene("Score_sceen"); }
    }
    public void LoadLevel(string name)
	{
		print("Level Load requested for " + name);
		SceneManager.LoadScene (name);
	}



    void OnCollisionEnter(Collision theCollision)
    {

        if (theCollision.gameObject.name == "P1AREA")
        {
            
            p2count = p2count + 1;
            p2.text = "P2:" + p2count.ToString();
        }

        else if(theCollision.gameObject.name == "P2AREA")
        {
           
            p2count = p1count + 1;
            p2.text = "P1:" + p1count.ToString();
        }
    }

   

    public void quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
