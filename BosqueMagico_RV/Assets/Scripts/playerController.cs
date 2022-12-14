using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float velocidad = 0.2f; //Velocidad de movimiento
    public bool movFrontal = false; 
    public bool movLateral = true; 

    //sonido
    public AudioSource sound;
    public AudioClip soundVictory;
    public float volumen = 1f;
    
    public Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody> ();
    }

    void Update(){ 
        float frontal = Input.GetAxis("Vertical");
        float lados = Input.GetAxis("Horizontal");

        if(movFrontal){
            movimientoFrontal(frontal);
        }
        else{
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        
        if(movLateral){
            movimientoLados(lados);
        }
        
    }

    private void movimientoFrontal(float h){
        if(h > 0){
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        if(h < 0){
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
    }

    private void movimientoLados(float h){
        if(h > 0){
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        if(h < 0){
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("detener")){
            velocidad = 0; 
        }
        if(collision.transform.CompareTag("victoria")){
            playSound();
            Destroy(collision.gameObject.GetComponent<Collider>());
        }
    }

    private void playSound(){
        sound.PlayOneShot(soundVictory, volumen);
    }
}
