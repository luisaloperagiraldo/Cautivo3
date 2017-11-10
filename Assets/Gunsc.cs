using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunsc : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera TPSCam;

    private void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(TPSCam.transform.position, TPSCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}