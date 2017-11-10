using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayViewver : MonoBehaviour {

    public float weaponRange = 50f;

    private Camera TpsCam;
    // Use this for initialization
    void Start()
    {
        TpsCam = GetComponentInParent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 lineOrigin = TpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawLine(lineOrigin, TpsCam.transform.forward * weaponRange, Color.green);
	}
}
