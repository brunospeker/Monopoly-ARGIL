using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXMenuInicial : MonoBehaviour
{
    public AudioSource Click;

    public void PlayClick(){
        Click.Play ();
    }

    public void changeVolume(float value){
        AudioListener.volume = value;
    }
}
