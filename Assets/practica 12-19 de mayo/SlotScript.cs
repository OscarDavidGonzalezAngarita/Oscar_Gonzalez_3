using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour
{
    inventory inventario;
    public int interaccion;

    private void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }
    private void Update()
    {
        if(transform.childCount <= 0)
        {
            inventario.isFull[interaccion] = false;
        }
    }





    public void dropItem()
    {
        foreach(Transform item in transform)
        {
            GameObject.Destroy(item.gameObject);
        }
    }
}
