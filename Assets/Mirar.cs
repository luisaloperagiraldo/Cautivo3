using UnityEngine;
using System.Collections;

public class Mirar : MonoBehaviour
{

    public Transform Objetivo;
    public float velocidad;

    void Start()
    {

    }

    void Update()
    {
        //Obtener la direccion, restando las posiciones (Vector3)
        Vector3 direccion = transform.position - Objetivo.position;
        //Crea la rotacion en base a la direccion
        Quaternion rotacion = Quaternion.LookRotation(direccion);
        //Aplicar la rotacion a nuestro objeto
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, velocidad * Time.deltaTime);
    }
}
