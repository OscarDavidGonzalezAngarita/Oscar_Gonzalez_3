using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _For_ : MonoBehaviour
{
    int _HorasDelDia = 25;
    void Start()
    {
        for(int i = 1; i < _HorasDelDia; i++)
        {
            Debug.Log("La Hora Es_" + i);
        }
    }
}
