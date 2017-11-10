using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = player.transform.position - transform.position;
	}

    private void LateUpdate()
    {
        float desireAngle = player.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desireAngle, 0);
        transform.position = player.transform.position - (rotation * offset);
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
