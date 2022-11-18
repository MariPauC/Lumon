using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class talkingCharacters : MonoBehaviour{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed =0.1f;
    
    int index; 

    //ventana
    GameObject dialogo;

    void Start(){
        //Encontrar las ventanas de menu
        dialogo = GameObject.FindGameObjectWithTag("subtitulo");
        dialogo.SetActive(false);
    }


    // Update is called once per frame
    void Update(){
        if(dialogueText.text == lines[index]){
            StartCoroutine(wait());
            NextLine(); 
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("Player")){
            dialogo.SetActive(true);
            dialogueText.text = string.Empty;
            playDialogue();
            Destroy(gameObject.GetComponent<Collider>());
        }
    }
    
    public void playDialogue(){
        index=0; 
        dialogueText.text = string.Empty;
        StartCoroutine(WriteLine());
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(10f);

        Debug.Log("Perate wey");
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
            gameObject.SetActive(false);
        }
    }
    
}
