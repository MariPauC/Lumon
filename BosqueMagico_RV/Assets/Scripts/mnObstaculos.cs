using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mnObstaculos : MonoBehaviour
{
    public void iniciotBtn()
    {
        SceneManager.LoadScene("Menus");
    }
    public void cambioBtn()
    {
        SceneManager.LoadScene("Comida");
    }
}
