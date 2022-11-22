using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicialManager : MonoBehaviour
{
	[SerializeField] private string sceneIniciarJogo;
	[SerializeField] private GameObject painelMenuPrincipal;
	[SerializeField] private GameObject painelConfiguracoes;
	[SerializeField] private GameObject painelQuantidadeJogadores;
	[SerializeField] private GameObject painelIconeJogadores;
	
    
    public void ModoSingle()
    {
        IconeJogadores();
		//SceneManager.LoadScene(sceneIniciarJogo);
    }

    public void ModoMulti()
    {
        QuantJogadores();
		IconeJogadores();
	//SceneManager.LoadScene(sceneIniciarJogo);
    }

    public void QuantJogadores()
    {
        painelMenuPrincipal.SetActive(false);
		painelConfiguracoes.SetActive(false);
		painelQuantidadeJogadores.SetActive(true);
		painelIconeJogadores.SetActive(false);
	//Retornar a quantidade
    }

    public void IconeJogadores()
    {
        
        painelMenuPrincipal.SetActive(false);
		painelConfiguracoes.SetActive(false);
		painelQuantidadeJogadores.SetActive(false);
		painelIconeJogadores.SetActive(true);
	//Retornar o icone escolhido
    }

    public void Configuracoes()
    {
        painelMenuPrincipal.SetActive(false);
		painelConfiguracoes.SetActive(true);
		painelQuantidadeJogadores.SetActive(false);
		painelIconeJogadores.SetActive(false);
    }

    public void Voltar()
    {
        painelMenuPrincipal.SetActive(true);
		painelConfiguracoes.SetActive(false);
		painelQuantidadeJogadores.SetActive(false);
		painelIconeJogadores.SetActive(false);
    }

    public void SairJogo()
    {
		Debug.Log("Sair do Jogo"); //Remover quando compilar
        Application.Quit();
    }

}
