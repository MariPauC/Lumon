using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class talkingCharacters : MonoBehaviour{
    //Sonido
    public AudioSource sound;
    public AudioClip characterVoice;
    public float volumen = 1f;
    
    //Texto
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed =0.1f;

    private float timeText = 3f;

    int index; 

    //ventana
    GameObject dialogo;
    GameObject boton;

    void Start(){
        //Encontrar las ventanas de menu
        dialogo = GameObject.FindGameObjectWithTag("subtitulo");
        boton = GameObject.FindGameObjectWithTag("botones");
        dialogo.SetActive(false);
        boton.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        timeText -= Time.deltaTime;
        if(timeText <= 0){
            if(dialogueText.text == lines[index]){
                NextLine();
            }
            timeText = 3f;
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("Player")){
            dialogo.SetActive(true);
            dialogueText.text = string.Empty;
            playDialogue();
            playSound();
            Destroy(gameObject.GetComponent<Collider>());
        }
    }
    
    public void playDialogue(){
        index=0; 
        dialogueText.text = string.Empty;
        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine(){
        foreach(char letter in lines[index].ToCharArray()){
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void NextLine(){
        if(index < lines.Length - 1){
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else{
            dialogo.SetActive(false);
            boton.SetActive(true);
        }
    }
    
    private void playSound(){
        sound.PlayOneShot(characterVoice, volumen);
    }
}
