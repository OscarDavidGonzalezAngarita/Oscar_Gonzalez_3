using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GeneradorDeCajas : MonoBehaviour
{
    public Transform caja;
    void Start()
    {
        for(int y = 0; y < 5; y++)
        {
            for(int x = 0;x < 5; x++)
            {
                //GameObject Cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //Cubo.GetComponent<Rigidbody>();
                //Cubo.transform.position = new Vector3(x, y, 0);

                Instantiate(caja, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }   
}
