using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatosJugador : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;

    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer == 100)
        {
            SceneManager.LoadScene("Ganado");
            //Debug.Log("GameOver");
        }
    }

    public void changeBarra(float cantData)
    {
        vidaVisual.value = cantData;
        if (vidaVisual.value == 100)
        {
            SceneManager.LoadScene("Ganado");
            //Debug.Log("GameOver");
        }
    }
}
