﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour {

	public float minDistance = 1.0f;
	public float maxDistance = 4.0f;
	public float smooth = 10.0f;
	public Vector3 playerDir;
	public Vector3 playerDirAdjusted;
	public float distance;

    public Transform player;

    // Use this for initialization
    void Awake ()
    {
		playerDir = transform.localPosition.normalized;
		distance = transform.localPosition.magnitude;
	}
	
	// Update is called once per frame
	void Update ()
    {

		Vector3 desiredCameraPos = player.transform.TransformPoint(playerDir * maxDistance);
		RaycastHit hit;

		if (Physics.Linecast (player.transform.position, desiredCameraPos, out hit))
        {

			    distance = Mathf.Clamp ((hit.distance * 0.87f), minDistance, maxDistance);		
		}
        else
        {

		    distance = maxDistance;

		}


		transform.localPosition = Vector3.Lerp (transform.localPosition, playerDir * distance, Time.deltaTime * smooth);
        
    }          
}
