using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoOso : MonoBehaviour
   // public AudioSource _audio;
{
    void OnTriggerEnter(Collider other)
    {
       // print("musica on");
       // _audio.Play();
    }

    void OnTriggerExit(Collider other)
    {
       // print("musica off");
        //_audio.Stop();
    }
}
