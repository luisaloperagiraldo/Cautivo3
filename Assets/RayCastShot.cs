﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShot : MonoBehaviour {

    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;

    public Camera TPScamera;
    private float NextFire;
    private LineRenderer laserLine;

    void Start ()
    {
        laserLine = GetComponent<LineRenderer>();

        TPScamera = GetComponentInParent<Camera>();
	}
	
	
	void Update ()
    {
		if (Input.GetButtonDown("Fire2")&& Time.time > NextFire)
        {
            NextFire = Time.time + fireRate;

            Vector3 rayOrigin = TPScamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            laserLine.SetPosition(0, gunEnd.position);

            if (Physics.Raycast(rayOrigin, TPScamera.transform.forward, out hit, weaponRange))
            {
                laserLine.SetPosition(1, hit.point);
            }
            else
            {
                laserLine.SetPosition(1, rayOrigin + (TPScamera.transform.forward * weaponRange));
            }

        }
	}
}
