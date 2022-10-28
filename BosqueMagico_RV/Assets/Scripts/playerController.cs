using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float velocidad = 0.2f;
    public Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody> ();
    }

    void Update(){
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        float h = Input.GetAxis("Horizontal");

        if(h > 0){
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        if(h < 0){
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
    }
}
