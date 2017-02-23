using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScreen : MonoBehaviour {

    public Text currentScore;
    public Text bestScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetInt("BestScore", 0);
        }
	}

    void OnEnable()
    {
        currentScore.text = "Last score: " + PlayerPrefs.GetInt("CurrentScore").ToString();
        bestScore.text = "Best score: " + PlayerPrefs.GetInt("BestScore").ToString();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
