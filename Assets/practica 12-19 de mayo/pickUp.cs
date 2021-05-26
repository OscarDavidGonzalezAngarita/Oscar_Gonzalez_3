using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    inventory inventario;
    public GameObject ItemButtom;
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            for(int i = 0; i <inventario.slots.Length; i++)
            {
                if(inventario.isFull[i] == false)
                {
                    inventario.isFull[i] = true;
                    Instantiate(ItemButtom, inventario.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
