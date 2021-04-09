using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _While_ : MonoBehaviour
{
    int goles = 1;
    void Start()
    {
        while(goles <= 4)
        {
            Debug.Log(goles);
            goles++;
        }
    }
}
