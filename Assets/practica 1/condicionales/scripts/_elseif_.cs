using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _elseif_ : MonoBehaviour
{
    public int disparos = 20;
    private int muchoPlomo = 15;
    private int demasiadoPlomo = 45;
    void Update()
    {
        eslseif();
    }
    void eslseif()
    {
        if(disparos < muchoPlomo)
        {
            print("el barrio esta tranquilo");
        }
        else if (disparos > demasiadoPlomo)
        {
            print("se bajaron al carlos");
        }  
        else
        {
            print("balacera estandar");
        }
    }
}
