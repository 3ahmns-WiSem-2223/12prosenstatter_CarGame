using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControll : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 90f;


    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {

            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.position -= transform.up * speed * Time.deltaTime;
        }
       

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


      
       transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed * horizontal);


    }
}
