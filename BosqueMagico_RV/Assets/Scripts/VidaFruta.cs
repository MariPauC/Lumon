using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaFruta : MonoBehaviour
{
    public int AunmVida;
    public GameObject Player;
    public AudioSource Emite;
    public AudioClip elSonido;
    public float volimen = 1f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.GetComponent<DatosJugador>().vidaPlayer += AunmVida; 
            Emite.PlayOneShot(elSonido, volimen);
            //Destroy(gameObject, 0.2f);
        }
    }
}
