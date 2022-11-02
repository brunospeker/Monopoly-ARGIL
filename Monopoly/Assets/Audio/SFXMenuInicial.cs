using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXMenuInicial : MonoBehaviour
{
    public AudioSource Crash;

    public void PlayCrash(){
        Crash.Play ();
    }
}
