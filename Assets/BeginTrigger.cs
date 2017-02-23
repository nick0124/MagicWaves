using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginTrigger : MonoBehaviour {

    public GameObject music;
    public GameObject noice;

    public Catcher wavesCatcher;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.transform.name == "MusicBegin")
        {
            music.SetActive(true);
            noice.SetActive(true);
        }

        if (coll.transform.name == "MusicEnd")
        {
            PlayerPrefs.SetInt("CurrentScore", (int)wavesCatcher.score);
            SceneManager.LoadScene("Finish");
            if(PlayerPrefs.HasKey("BestScore") == true)
            {
                if (PlayerPrefs.GetInt("BestScore") < (int)wavesCatcher.score)
                {
                    PlayerPrefs.SetInt("BestScore", (int)wavesCatcher.score);
                }
            }
            else
            {
                PlayerPrefs.SetInt("BestScore", (int)wavesCatcher.score);
            }
        }

    }
}
