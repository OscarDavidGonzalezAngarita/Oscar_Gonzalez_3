using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectoresPractica : MonoBehaviour
{
    public float speed;
    public GameObject enemigo;
    public Renderer rendEnemigo;
    void Start()
    {
        enemigo = GameObject.Find("no");
        rendEnemigo = GameObject.Find("no").GetComponent<Renderer>();
        
    }
    void Update()
    {
        Vector2 posEnemigo = enemigo.transform.position;
        Vector2 posJugador = transform.position;

        float distancia = Vector2.Distance(posEnemigo, posJugador);
        

        if(distancia < 5)
        {
            print("no te me acerques!!");
            rendEnemigo.material.SetColor("_BaseColor", Color.red);
        }
        if (distancia > 5)
        {
            rendEnemigo.material.SetColor("_BaseColor", Color.green);
        }
    }
    private void OnDrawGizmos()
    {
        Vector2 posEnemigo = enemigo.transform.position;
        Vector2 posJugador = transform.position;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(posJugador, posEnemigo);
    }
}
