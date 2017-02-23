using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualScroller : MonoBehaviour {

    public float minX;
    public float maxX;

    public float catcherMin;
    public float catcerMax;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float catcherDist = catcerMax - catcherMin;
        float onePerc = catcherDist / 100;
    }
}
