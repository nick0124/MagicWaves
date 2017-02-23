using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Catcher : MonoBehaviour {

    public Vector3 mouseWorldPos;

    public float score = 0;

    public bool catchWave;

    public Text scoreText;

    private float catcherPosY;

    public float maxYpos;
    public float minYpos;

    public AudioSource music;
    public AudioSource noice;

    public GameObject notesParticle;

	// Use this for initialization
	void Start () {
        catcherPosY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if(catchWave)
        {
            //ловим волну
            score += 0.1f;
            scoreText.text = "Score: "+ ((int)score).ToString();

            music.volume = 1;
            noice.volume = 0;

            notesParticle.GetComponent<ParticleSystem>().enableEmission = true;
        }
        else
        {

            if(score>0)
            {
                score -= 0.1f;
                scoreText.text = "Score: " + ((int)score).ToString();
            }
            //не ловим волну
            music.volume = 0;
            noice.volume = 1;

            notesParticle.GetComponent<ParticleSystem>().enableEmission = false;
        }
	}
    void FixedUpdate()
    {
        //управление
        MouseControlls();
        //TwhoButtonControlls();
        //SpaceControlls();
        //MouseScrollControlls();
    }

    private void MouseScrollControlls()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && transform.position.y < maxYpos)
        {
            catcherPosY += 0.1f;
            transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0 && transform.position.y > minYpos)
        {
            catcherPosY -= 0.1f;
            transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }
    }

    private void MouseControlls()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
        if (transform.position.y > maxYpos)
        {
            transform.position = new Vector3(transform.position.x, maxYpos, transform.position.z);
        }
        else if (transform.position.y < minYpos)
        {
            transform.position = new Vector3(transform.position.x, minYpos, transform.position.z);
        }
        else if (mouseWorldPos.y > minYpos && mouseWorldPos.y < maxYpos)
        {
            transform.position = new Vector3(transform.position.x, mouseWorldPos.y, transform.position.z);
        }
    }
    private void TwhoButtonControlls()
    {

        if (Input.GetKey(KeyCode.W) && transform.position.y < maxYpos)
        {
            catcherPosY += 0.1f;
            transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.y>minYpos)
        {
            catcherPosY -= 0.1f;
            transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }
    }
    private void SpaceControlls()
    {
        if (Input.GetKey(KeyCode.Space) && transform.position.y < maxYpos)
        {
            catcherPosY += 0.05f;
            transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }
        else if(Input.GetKey(KeyCode.Space) == false && transform.position.y>minYpos)
        {
            catcherPosY -= 0.05f;
            transform.position = new Vector3(transform.position.x, catcherPosY, transform.position.z);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wave")
            catchWave = true;

    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wave")
            catchWave = false;

    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wave")
            catchWave = true;
    }
}
