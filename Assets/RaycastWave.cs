using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastWave : MonoBehaviour {

    public GameObject magician;
    public float rayUp;
    public float rayDown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hitUp = Physics2D.Raycast(transform.position, Vector2.up);
        if (hitUp.collider != null)
        {
            rayUp = Mathf.Abs(hitUp.point.y - transform.position.y);
            //magician.transform.position = new Vector3(transform.position.x, -rayUp, transform.position.z);
        }
        RaycastHit2D hitDown = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hitDown.collider != null)
        {
            rayDown = Mathf.Abs(hitDown.point.y - transform.position.y);
            //magician.transform.position = new Vector3(transform.position.x, -rayDown, transform.position.z);
        }

        if(rayUp>0)
        {
            magician.transform.position = new Vector3(magician.transform.position.x, rayUp, magician.transform.position.z);
        }
        else if(rayDown>0)
        {
            magician.transform.position = new Vector3(magician.transform.position.x, -rayDown, magician.transform.position.z);
        }
	}

}
