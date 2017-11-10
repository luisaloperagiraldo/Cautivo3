using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;


    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
    
        var bullet = (GameObject)Instantiate(bulletPrefab,bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward *30;

        Destroy(bullet, 2.0f);
    }


}
