using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class obstacleCollision : MonoBehaviour{
    //Sonido
    public AudioSource sound;
    public AudioClip soundCollision;
    public float volumen = 1f;
    
    //Barra 
    [SerializeField] private barraObstaculos barra;

    //Puntaje
    private int puntaje = 100;
    private bool visible = true; 

    void Star(){
        barra.playBarra(puntaje);
    }
    
    //Comprobar si existe choque con el jugador 
    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("obstaculos")){
            contadorPuntos();
            Destroy(collision.gameObject);
            playSound();
        }
        if(collision.transform.CompareTag("victoria")){
            barra.close();
        }
    }

    private void contadorPuntos(){
        puntaje = puntaje - 25;
        barra.changeBarra(puntaje);
        if (puntaje <=0){
            SceneManager.LoadScene("Perdido");
        }
    }

    private void playSound(){
        sound.PlayOneShot(soundCollision, volumen);
    }
}
