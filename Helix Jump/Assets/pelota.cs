using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    Rigidbody ballRG;
    [SerializeField] float forceJump = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //ver videos en youtube de como hacer esto
        ballRG = GetComponent <Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ballRG.velocity = Vector3.zero;
        ballRG.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
    }

}
