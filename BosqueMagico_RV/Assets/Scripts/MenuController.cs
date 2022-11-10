using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour{
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
    
    public void StartBtn(){
        SceneManager.LoadScene("juego");
    }

    public void OpcBtn(){
        ocultarVentanas();
        ventana3.SetActive(true);
    }
    public void CredBtn(){
        ocultarVentanas();
        ventana4.SetActive(true);
    }

    public void VolverBtn(){
        ocultarVentanas();
        ventana1.SetActive(true);
    }

    private void ocultarVentanas(){
        ventana1.SetActive(false);
        ventana3.SetActive(false);
        ventana4.SetActive(false);
    }
}
