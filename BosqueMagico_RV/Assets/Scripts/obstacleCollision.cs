using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class obstacleCollision : MonoBehaviour{
    private int puntaje = 100;
    private bool visible = true; 
    
    //Comprobar si existe choque con el jugador 
    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("obstaculos")){
           if (visible){
                contadorPuntos();
                StartCoroutine(desaparecer());
           }
        }
    }

    private void contadorPuntos(){
        puntaje = puntaje - 25;
        Debug.Log(puntaje);
        if (puntaje <=0){
            SceneManager.LoadScene("Perdido");
        }
    }

    IEnumerator desaparecer(){
        visible = false;
        yield return new WaitForSeconds(2);
        visible = true;
    }

    private void sound(){

    }
}
