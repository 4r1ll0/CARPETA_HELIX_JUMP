using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    Rigidbody ballRG;
    [SerializeField] float forceJump = 5f;
    [SerializeField] GameObject trail;
    //Variable para almacenar altura inicial


    //Variable para almacenar altura final


    void Start()
    {
        //ver videos en youtube de como hacer esto
        ballRG = GetComponent <Rigidbody>();
        trail.SetActive(false);

        //Guardar la altura inicial
    }

    private void OnCollisionEnter(Collision collision)
    {
        ballRG.velocity = Vector3.zero;
        ballRG.AddForce(Vector3.up * forceJump, ForceMode.Impulse);

        //Guardar altura final

        //Distancia recorrida = Restar incial - final

        // Mostrar en un log la distancia recorrida
        
        
    }

}