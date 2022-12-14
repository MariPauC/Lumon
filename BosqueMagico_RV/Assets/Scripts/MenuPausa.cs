using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach(AudioSource a in audios)
        {
           a.Pause();
        }
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.Play();
        }
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        //Debug.Log("cerrando juego");
        //Application.Quit();
        SceneManager.LoadScene("Menus");
    }

    public void Cambio()
    {
        SceneManager.LoadScene("Obstaculos");
    }

    public void SegCambio()
    {
        SceneManager.LoadScene("Comida");
    }
}
