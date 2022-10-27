using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class navegacion_menu : MonoBehaviour
{
    GameObject ventana1;
    GameObject ventana3;
    GameObject ventana4;

    void Start(){        
        //Encontrar las ventanas de menu
        ventana1 = GameObject.FindGameObjectWithTag("mn_inicial");
        ventana3 = GameObject.FindGameObjectWithTag("mn_opciones");
        ventana4 = GameObject.FindGameObjectWithTag("mn_creditos");

        //Ajustar las ventanas de menu, solo aparezaca la principal.
        ocultarVentanas();
        ventana1.SetActive(true);
    }

    public void navegar_a(ref int parametroControlador){
        ocultarVentanas();
        switch (parametroControlador)
        {
            case 1:ventana1.SetActive(true); break;
            case 2:
                //Cargar la siguiente escena para cuando se vaya a iniciar
                SceneManager.LoadScene("Juego_1"); 
                break;
            case 3:ventana3.SetActive(true); break;
            case 4:ventana4.SetActive(true); break;
            default:break;
        }
    }

    void ocultarVentanas(){
        ventana1.SetActive(false);
        ventana3.SetActive(false);
        ventana4.SetActive(false);
    }

}
