using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Array_ : MonoBehaviour
{
    public string[]arrays = new string[5] {"no", "se me", "ocurrio", "nada", "en especial"};
    void Start()
    {
        arrays[0] = ("no");
        arrays[1] = ("se me");
        arrays[2] = ("ocurrio");
        arrays[3] = ("nada");
        arrays[4] = ("en especial");
    }
}
