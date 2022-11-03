using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vistaCredito : MonoBehaviour
{
    controlMenu Class_contmenu;
    
    void Start()
    {
        Class_contmenu = GameObject.FindGameObjectWithTag("mn_creditos").GetComponent<controlMenu>();
    }

    public void Onclick_botones(int parametroVista){
        Class_contmenu.evento(ref parametroVista);
    }
}

