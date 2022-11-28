using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadoScript : MonoBehaviour
{

    //Funcionava apenas para um objeto
    //static Rigidbody rb;
    private Rigidbody rb; // Tentativa para funcionar em dois objetos -> funcionou
    public static Vector3 dadoUmParado;
    public static Vector3 dadoDoisParado;

    //private GameObject DadoUm;
    //private GameObject DadoDois;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //DadoUm =  GameObject.Find("DadoUm");
        //DadoDois =  GameObject.Find("DadoDois");
        //DadoUm.SetActive(true);
        //DadoDois.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void levantarDado()
    {
        //Ativa os dados para lançar
        //DadoUm.SetActive(true);
        //DadoDois.SetActive(true);

        //Pegar o instante quando o dado para
        if (gameObject.name == "DadoUm")
        {
            dadoUmParado = rb.velocity;
        }
        
        if (gameObject.name == "DadoDois")
        {
            dadoDoisParado = rb.velocity;
        }

        // Randomizar a girada do dado
        float dirX = Random.Range (-500, 500);
        float dirY = Random.Range (-500, 500);
        float dirZ = Random.Range (-500, 500);

        float diffX = Random.Range (-6, 6);
        float diffZ = Random.Range (-6, 6);

        //Objeto indo para a posição de lançamento inicial
        transform.position = new Vector3 (diffX, 20, diffZ);
        //transform.Translate(0, 0, 20);
        transform.rotation = Quaternion.identity;

        //Objeto rotacionando
        //transform.Rotate(dirX, dirY, dirZ);
        rb.AddForce (transform.up * 500);
        rb.AddTorque (dirX, dirY, dirZ);
        

    }
}
