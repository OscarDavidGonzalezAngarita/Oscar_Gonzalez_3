using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarma : MonoBehaviour
{
    static _Enemigo estancia;
    static alarma alarmaa;

    private void Awake()
    {
        alarmaa = this;
    }
    void Start()
    {
        
    }
    public static alarma GetInstance()
    {
        return alarmaa;
    }
    public void impresion()
    {
        print("Te van a matar");
    }
    
    void Update()
    {
        
            
        
    }
}
