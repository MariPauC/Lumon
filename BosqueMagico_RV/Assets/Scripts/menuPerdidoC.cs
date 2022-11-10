using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuPerdidoC : MonoBehaviour
{
    public void volverJugarBtn(){
        SceneManager.LoadScene("Obstaculos");
    }

    public void cambioCBtn(){
        SceneManager.LoadScene("Comida");
    }
}

