using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour {

    public Catcher wavesCatcher;

    public float gameTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        gameTime -= Time.deltaTime;

        if (gameTime<0)
        {
            Finish();
        }
	}

    public void Finish()
    {
        PlayerPrefs.SetInt("CurrentScore", (int)wavesCatcher.score);
        SceneManager.LoadScene("Finish");

    }
}
