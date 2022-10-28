using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotMenu : MonoBehaviour { 
    public AudioSource sound;
    public AudioClip soundMenu;

   public void SoundBotton()
    {
        sound.clip = soundMenu;

        sound.enabled = false;
        sound.enabled = true;
    }
}
