using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class obstacleCollision : MonoBehaviour{
    public AudioSource sound;
    public AudioClip soundCollision;
    public float volumen = 1f;
    
    private int puntaje = 100;
    private bool visible = true; 
    
    //Comprobar si existe choque con el jugador 
    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("obstaculos")){
           contadorPuntos();
           Destroy(collision.gameObject);
           playSound();
        }
    }

    private void contadorPuntos(){
        puntaje = puntaje - 25;
        Debug.Log(puntaje);
        if (puntaje <=0){
            SceneManager.LoadScene("Perdido");
        }
    }

    private void playSound(){
        sound.PlayOneShot(soundCollision, volumen);
    }
}
