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
        IconeJogadores()
	SceneManager.LoadScene(sceneIniciarJogo);
    }

    public void ModoMulti()
    {
        QuantJogadores()
	IconeJogadores()
	//SceneManager.LoadScene(sceneIniciarJogo);
    }

    public void QuantJogadores()
    {
        painelMenuPrincipal.setActive(false);
	painelConfiguracoes.setActive(false);
	painelQuantidadeJogadores.setActive(true);
	painelIconeJogadores.setActive(false);
	//Retornar a quantidade
    }

    public void IconeJogadores()
    {
        
        painelMenuPrincipal.setActive(false);
	painelConfiguracoes.setActive(false);
	painelQuantidadeJogadores.setActive(false);
	painelIconeJogadores.setActive(true);
	//Retornar o icone escolhido
    }

    public void Configuracoes()
    {
        painelMenuPrincipal.setActive(false);
	painelConfiguracoes.setActive(true);
	painelQuantidadeJogadores.setActive(false);
	painelIconeJogadores.setActive(false);
    }

    public void Voltar()
    {
        painelMenuPrincipal.setActive(true);
	painelConfiguracoes.setActive(false);
	painelQuantidadeJogadores.setActive(false);
	painelIconeJogadores.setActive(false);
    }

    public void SairJogo()
    {
	Debug.log("Sair do Jogo") //Remover quando compilar
        Application.Quit()
    }

}
