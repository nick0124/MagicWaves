using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicianDown : MonoBehaviour {

    private float catcherPosY;

    public GameObject magician;

    public bool catchWave = false;

    public float rayDist;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (catchWave == true)
        {
            catcherPosY += 0.06f;
            magician.transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }
        else if (catchWave == false)
        {
            catcherPosY -= 0.06f;
            magician.transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }*/
	}

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            rayDist = Mathf.Abs(hit.point.y - transform.position.y);
            magician.transform.position = new Vector3(transform.position.x, -rayDist, transform.position.z);
            //float heightError = floatHeight - distance;
            //float force = liftForce * heightError - rb2D.velocity.y * damping;
            //rb2D.AddForce(Vector3.up * force);
        }
    }
    
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wave")
            catchWave = true;
        /*
        if (coll.gameObject.tag == "Wave")
        {
            catcherPosY -= 0.01f;
            magician.transform.position = new Vector3(transform.position.x, catcherPosY);
        }*/
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        

    }
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wave")
            catchWave = false;

    }
}
