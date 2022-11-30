using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturaNumeroDadoScript : MonoBehaviour
{
    Vector3 dadoUmParado;
    Vector3 dadoDoisParado;

    private BoxCollider tabuleiro, captura;


    // Start is called before the first frame update
    void Start()
    {
        tabuleiro = GameObject.Find("TabuleiroBlender").GetComponent<BoxCollider>();
        captura = GetComponent<BoxCollider>();

        Physics.IgnoreCollision(captura, tabuleiro, true);
    }

    // Update is called once per frame
    void ForceUpdate()
    {
        dadoUmParado = DadoScript.dadoUmParado;
        dadoDoisParado = DadoScript.dadoDoisParado;
    }

    void OnTriggerStay(Collider col)
    {
        if(dadoUmParado.x == 0f && dadoUmParado.y == 0f && dadoUmParado.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "D1Face1":
                    //dadoUmNumero = 6;
                    print("DadoUm - 6");
                    break;
                case "D1Face2":
                    //dadoUmNumero = 5;
                    print("DadoUm - 5");
                    break;
                case "D1Face3":
                    //dadoUmNumero = 4;
                    print("DadoUm - 4");
                    break;
                case "D1Face4":
                    //dadoUmNumero = 3;
                    print("DadoUm - 3");
                    break;
                case "D1Face5":
                    //dadoUmNumero = 2;
                    print("DadoUm - 2");
                    break;
                case "D1Face6":
                    //dadoUmNumero = 1;
                    print("DadoUm - 1");
                    break;
            }
        }

        if(dadoDoisParado.x == 0f && dadoDoisParado.y == 0f && dadoDoisParado.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "D2Face1":
                    //dadoDoisNumero = 6;
                    print("DadoDois - 6");
                    break;
                case "D2ace2":
                    //dadoDoisNumero = 5;
                    print("DadoDois - 5");
                    break;
                case "D2Face3":
                    //dadoDoisNumero = 4;
                    print("DadoDois - 4");
                    break;
                case "D2Face4":
                    //dadoDoisNumero = 3;
                    print("DadoDois - 3");
                    break;
                case "D2Face5":
                    //dadoDoisNumero = 2;
                    print("DadoDois - 2");
                    break;
                case "D2Face6":
                    //dadoDoisNumero = 1;
                    print("DadoDois - 1");
                    break;
            }
        }
    }

}
