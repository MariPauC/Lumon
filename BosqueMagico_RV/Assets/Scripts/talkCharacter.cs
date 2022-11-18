using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkCharacter : MonoBehaviour
{
    //sonido
    public AudioSource sound;
    public AudioClip soundVictory;
    public float volumen = 1f;

    public int yaHablo = 0;

    //ventana
    GameObject dialogo;
    
    // Update is called once per frame
    void Start()
    {
        //Encontrar las ventanas de menu
        dialogo = GameObject.FindGameObjectWithTag("conversar");
        //dialogo.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("hablar")){
            if(yaHablo <= 0){
                //dialogo.SetActive(true);
                yaHablo = yaHablo + 1;
                playSound(); 
            }
        }
    }

    private void playSound(){
        sound.PlayOneShot(soundVictory, volumen);
    }
}
