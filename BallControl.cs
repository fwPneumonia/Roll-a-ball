using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour {
    Rigidbody physic;
    public int velocity;
    int counter = 0;
    public Text countertext;

    public Text gameoverText;
    public int collectingobjectnumber;
	// Use this for initialization
	void Start ()
    {
        physic = GetComponent<Rigidbody>();
        countertext.text = "Counter = 0";
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(horizontal, 0, vertical);
        physic.AddForce(vec*velocity);


        //Debug.Log("yatay= "+yatay+"    dikey = "+dikey);
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObjectToBeCollected") { }
        other.gameObject.SetActive(false);
        counter++;
        countertext.text = "Counter=" + counter;
        if (counter == collectingobjectnumber)
        {
            gameoverText.text = "Game Over!";
        }
    }
    }

