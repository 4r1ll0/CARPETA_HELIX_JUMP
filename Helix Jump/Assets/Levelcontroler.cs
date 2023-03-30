using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelcontroler : MonoBehaviour
{

    [SerializeField] float speed = 5f;

    void Update()
    {
        
        Vector3 rot = new Vector3(0f, Input.GetAxis("Horizontal"));
        transform.Rotate(rot * speed * Time.deltaTime);
    }

    
}
