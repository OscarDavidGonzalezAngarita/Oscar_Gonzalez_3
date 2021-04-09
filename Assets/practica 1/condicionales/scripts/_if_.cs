using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _if_ : MonoBehaviour
{
    public int vida = 5;
    void Start()
    {
        
    }

    void Update()
    {
        _vida_();
    }
    void _vida_()
    {
        if(vida <= 0)
        {
            print("morido papa");
        }
    }
}
