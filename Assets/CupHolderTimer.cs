using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CupHolderTimer : MonoBehaviour {

    public float time;

    public GameObject cap;
    public GameObject capHolder;

    private bool timerStart = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayBtn()
    {
        cap.GetComponent<Rigidbody2D>().isKinematic = false;
        timerStart = true;
    }

    void FixedUpdate()
    {
        if (timerStart == true)
        { 
            time -= Time.deltaTime;
            if(time<0)
            {
                capHolder.SetActive(false);
            }
            if (time < -2)
            {
                //SceneManager.LoadScene("main");
            }
        }
    }
}
