using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlMenu : MonoBehaviour
{
    navegacion_menu Class_navegacionMn;

    void Start()
    {
        Class_navegacionMn = GameObject.FindGameObjectWithTag("navegacionMn").GetComponent<navegacion_menu>();
    }

    public void evento(ref int parametroControlador){
        Class_navegacionMn.navegar_a(ref parametroControlador);
    }

}
