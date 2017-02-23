using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWave : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if(time<0)
        {
            Debug.Log("stop");
            Time.timeScale = 0;
        }
	}
}
