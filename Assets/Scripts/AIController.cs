using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    private int health = 10;

 
	void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ( "Bullet"))
        {
            health--; 
        }

        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
