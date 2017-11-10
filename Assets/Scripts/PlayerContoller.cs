using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour {

    public float movementSpeed = 10;
    public float rotationSpeed = 60;


    private void Start()
    {
  
    }

    void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Movimiento
        Vector3 movement = new Vector3(0, 0, vertical) * Time.deltaTime * movementSpeed;
        transform.Translate(movement);

        //Rotación
        Vector3 rotation = new Vector3(0, horizontal, 0) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }
}
