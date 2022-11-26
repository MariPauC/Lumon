using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraVida : MonoBehaviour
{
    public float vida = 100;
    public Image Barravida;

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        Barravida.fillAmount = vida/100;
        if (vida == 1)
        {
            SceneManager.LoadScene("Ganado");
        }
    }
}
