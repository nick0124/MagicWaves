using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicianUp : MonoBehaviour {

    private float catcherPosY;

    public GameObject magician;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wave")
        {
            catcherPosY -= 0.01f;
            magician.transform.position = new Vector3(transform.position.x, catcherPosY);
        }
    }
}
