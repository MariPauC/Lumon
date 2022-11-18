using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textGuardian : MonoBehaviour{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed =0.2f;
    
    int index; 

    private int alreadyTalk = 0; 


    // Update is called once per frame
    void Update()
    {
        if(dialogueText.text == lines[index]){
            //StartCoroutine(wait());
            NextLine(); 
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("Player")){
            if(alreadyTalk <= 0){
                dialogueText.text = string.Empty;
                playDialogue();
                Destroy(gameObject.GetComponent<Collider>());
            }
        }
    }
    
    public void playDialogue(){
        index=0; 
        StartCoroutine(WriteLine());
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator WriteLine(){
        foreach(char letter in lines[index].ToCharArray()){
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine(){
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
