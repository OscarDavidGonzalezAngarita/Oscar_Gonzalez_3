using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GuiaDeAnimales : MonoBehaviour
{
    public string _NombreComun;
    public string _Grupo;
    public string _Familia;
    public int _NumeroDeEspecies;
    public bool _Extinto;
    public bool _Domesticado;
    public _GuiaDeAnimales guia;

   public bool _LaGuia(_GuiaDeAnimales guia)
    {
        return this.guia == guia;
    }
}
