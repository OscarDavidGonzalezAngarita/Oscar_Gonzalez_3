using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ForEach_ : MonoBehaviour
{
    string[] frutas = { "Manzana", "Papaya", "Naranja", "Melon" };
    void Start()
    {
        foreach(string fruta in frutas)
        {
            Debug.Log(fruta);
        }
    }
}
