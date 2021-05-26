using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoHumanoide : MonoBehaviour
{
    Rigidbody rb;
    float input_x;
    float input_z;
    public float speed = 5;
    Vector3 inputDirection;
    Vector3 rotationSpeed = new Vector3(0,100,0);

    public float vida = 5;

    Animator animatorController;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animatorController = GetComponent<Animator>();
    }
    void Update()
    {
        movimiento();
        //animatorController.SetFloat("forward", inputDirection.z);
        
    }
    void movimiento()
    {
        rb.velocity = new Vector3(input_x * speed, rb.velocity.y, input_z * speed);
         
        Vector3 m_input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        float velocidadX = Input.GetAxis("Vertical");
        animatorController.SetFloat("velocidadZ", velocidadX);
        
        rb.MovePosition(rb.position + (transform.forward * inputDirection.z * Time.deltaTime * speed));
        inputDirection = m_input.normalized;

        Quaternion deltaRotation = Quaternion.Euler(inputDirection.x * rotationSpeed * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
