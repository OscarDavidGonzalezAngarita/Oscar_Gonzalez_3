using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Enemigo : MonoBehaviour
{
    private int daño = -1;
    public GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gm.salud(daño);
        }
    }
}
