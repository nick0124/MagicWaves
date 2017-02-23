using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWave : MonoBehaviour {

    public float speed;
    public GameObject wave;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void FixedUpdate()
    {
        Vector3 move = new Vector3(speed, 0, 0);
        wave.transform.position -= move;
    }
}
