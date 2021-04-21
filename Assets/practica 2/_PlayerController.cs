using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2.0f;
    private float moveInputX;
    private float moveInputZ;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameManager.GetInstance();
    }
    void Update()
    {
        moveInputX=Input.GetAxis("Horizontal");
        moveInputZ=Input.GetAxis("Vertical");


        movimiento();
    }
    void movimiento()
    {
        rb.velocity = new Vector3(moveInputX * speed, rb.velocity.y, moveInputZ * speed);
    }
}
