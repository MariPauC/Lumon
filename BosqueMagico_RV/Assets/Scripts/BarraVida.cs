using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public float vida = 100;
    public Image Barravida;

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        Barravida.fillAmount = vida/100;
    }
}
