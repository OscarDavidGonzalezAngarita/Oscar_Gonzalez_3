using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Dictionary_ : MonoBehaviour
{
    Dictionary<string, int> armas = new Dictionary<string, int>();
    void Start()
    {
        armas.Add("Espada", 10);
        armas.Add("Lanza", 12);
        armas.Add("Arco", 6);
        armas.Add("Mazo", 15);
        Debug.Log(armas["Espada"]);
        Debug.Log(armas["Lanza"]);
        Debug.Log(armas["Arco"]);
        Debug.Log(armas["Mazo"]);
    }
}
