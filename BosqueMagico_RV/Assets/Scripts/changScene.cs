using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class changScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("obstaculos")){
            SceneManager.LoadScene("Obstaculos");
        }
        if(collision.transform.CompareTag("comida")){
            SceneManager.LoadScene("Comida");
        }
    }
}
