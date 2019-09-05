using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject Ball;
    Vector3 distancebetween;
	void Start ()
    {
        distancebetween = transform.position - Ball.transform.position;
	}
	
	
	void LateUpdate ()
    {
        transform.position = Ball.transform.position + distancebetween;

	}
}
