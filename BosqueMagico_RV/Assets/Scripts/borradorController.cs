using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borradorController : MonoBehaviour
{
    public float velocidad = 0.2f; //Velocidad de movimiento

    public Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody> ();
    }
    
    void Update(){
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("obstaculos")){
            Destroy(collision.gameObject);
        }
        if(collision.transform.CompareTag("victoria")){
            Destroy(gameObject); 
        }
    }

}
