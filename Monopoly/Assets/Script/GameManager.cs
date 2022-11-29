using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int activePlayer;
    int diceNumber;
    public DadoScript DadoScript;

    [System.Serializable]
    public class Player
    {
        public string name;
        public Token token;

        public enum PlayerTypes
        {
            HUMAN,
            IA
        };
        public PlayerTypes playerType;

    }

    public List<Player> players = new List<Player>();

    public enum States
    {
        WAITING,
        ROLL_DICE,
        SWITCH_PLAYER
    }
    public States state;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(players.Count < 1) return;

        if(players[activePlayer].playerType == Player.PlayerTypes.IA)
        {
            switch(state)
            {
                case States.WAITING:

                    break;
                case States.ROLL_DICE:
                    StartCoroutine(RollDiceDelay());
                    state = States.WAITING;
                    break;
                case States.SWITCH_PLAYER:
                    activePlayer = (++activePlayer >= players.Count) ? 0 : activePlayer;
                    state = States.ROLL_DICE;
                    break;
            }
        }
    }

    IEnumerator RollDiceDelay()
    {
        yield return new WaitForSeconds(2);
        diceNumber = Random.Range(1,7);
        Debug.Log(diceNumber);

        players[activePlayer].token.MakeTurn(diceNumber);
    }
}
