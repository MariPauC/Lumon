using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraObstaculos : MonoBehaviour
{
    private Slider slider;

    private void Start(){
        slider = GetComponent<Slider>();
    }

    public void maxBarra(float maximo){
        slider.maxValue = maximo;
    }

    public void changeBarra(float cantData){
        slider.value = cantData;
    }

    public void playBarra(float cantData){
        maxBarra(cantData);
        changeBarra(cantData);
    }

    public void close(){
        Destroy(slider.gameObject); 
    }
}
