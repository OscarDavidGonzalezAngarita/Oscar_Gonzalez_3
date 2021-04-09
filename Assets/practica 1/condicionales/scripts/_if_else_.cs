using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _if_else_ : MonoBehaviour
{
    private int tamaño;
    private Transform escala;
    void Start()
    {
        tamaño = 1;
        escala = GameObject.Find("_if_else_").GetComponent<Transform>();
    }
    void Update()
    {
        cambio();
        _Tamaño_();
    }
    void cambio()
    {
        if (tamaño <= 2)
        {
            escala.localScale = new Vector3(1,1,1);
        }
        else
        {
            escala.localScale = new Vector3(2, 2, 2);
        }
    }
    void _Tamaño_()
    {
        if(Input.GetKeyDown("up"))
        {
            tamaño += 1;
        }
        if (Input.GetKeyDown("down"))
        {
            tamaño -= 1;
        }
    }
}
