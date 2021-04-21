using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Presentacion : MonoBehaviour
{
    public _GuiaDeAnimales _Gato;
    public _GuiaDeAnimales _Dodo;
    public _GuiaDeAnimales _Escarabajos;
    void Start()
    {
        _Gato = new _GuiaDeAnimales();
        _Gato._NombreComun = "Gato";
        _Gato._Familia = "Mininos";
        _Gato._Grupo = "Felinos";
        _Gato._NumeroDeEspecies = 1;
        _Gato._Extinto = false;
        _Gato._Domesticado = true;

        _Dodo = new _GuiaDeAnimales();
        _Dodo._NombreComun = "Dodo";
        _Dodo._Familia = "Columbidae";
        _Dodo._Grupo = "Raphinae";
        _Dodo._NumeroDeEspecies = 1;
        _Dodo._Extinto = true;
        _Dodo._Domesticado = false;

        _Escarabajos = new _GuiaDeAnimales();
        _Escarabajos._NombreComun = "Escarabajos";
        _Escarabajos._Familia = "Exapoda";
        _Escarabajos._Grupo = "Coleoptera";
        _Escarabajos._NumeroDeEspecies = 13000;
        _Escarabajos._Extinto = false;
        _Escarabajos._Domesticado = false;



    }

}
