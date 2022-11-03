using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("juego");
    }
    public void OpcBtn()
    {
        SceneManager.LoadScene("Perdido");
    }
    public void CredBtn()
    {
        SceneManager.LoadScene("juego");
    }
}
