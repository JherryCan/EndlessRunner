﻿using UnityEngine;
using System.Collections;

public class PlatformGenarator : MonoBehaviour {

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;	

	void Start () { 
        platformWidth = thePlatform.GetComponent<BoxCollider>().size.x;
	}
	
	void Update () {
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatform, transform.position, transform.rotation);
        }
	}
}
