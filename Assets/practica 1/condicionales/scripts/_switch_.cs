using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _switch_ : MonoBehaviour
{
    private int losColores_;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void Update()
    {
        losColores();
        _EestablecerColores();
    }
    void losColores()
    {
        switch(losColores_)
        {
            case 8:
                if (losColores_ == 8)
                {
                    rend.material.SetColor("_BaseColor", Color.magenta);
                }
                break;
            case 7:
                if (losColores_ == 7)
                {
                    rend.material.SetColor("_BaseColor", Color.yellow);
                }
                break;
            case 6:
                if (losColores_ == 6)
                {
                    rend.material.SetColor("_BaseColor", Color.cyan);
                }
                break;
            case 5:
                if (losColores_ == 5)
                {
                    rend.material.SetColor("_BaseColor", Color.green);
                }
                break;
            case 4:
                if(losColores_ == 4)
                {
                    rend.material.SetColor("_BaseColor", Color.grey);
                }
                break;
            case 3:
                if (losColores_ == 3)
                {
                    rend.material.SetColor("_BaseColor", Color.red);
                }
                break;
            case 2:
                if (losColores_ == 2)
                {
                    rend.material.SetColor("_BaseColor", Color.black);
                }
                break;
            case 1:
                if (losColores_ == 1)
                {
                    rend.material.SetColor("_BaseColor", Color.blue);
                }
                break;
            case 0:
                if (losColores_ == 0)
                {
                    rend.material.SetColor("_BaseColor", Color.white);
                }
                break;
        }
    }
    void _EestablecerColores()
    {
        if(Input.GetKeyDown("right") && losColores_ <8)
        {
            losColores_+=1;
        }
        if (Input.GetKeyDown("left") && losColores_ >0)
        {
            losColores_ -= 1;
        }
    }
}
