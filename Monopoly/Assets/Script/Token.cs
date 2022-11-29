using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    public Route route;
    public List<Node> nodeList = new List<Node>();

    int routePosition;
    int tokenId;
    float speed = 8f;

    int stepsToMove;
    int doneSteps;
    bool isMoving;

    void Start()
    {
        foreach(Transform c in route.childNodeList)
        {
            Node n = c.GetComponentInChildren<Node>();
            if(n!=null)
            {
                nodeList.Add(n);
            }
        }
    }

    IEnumerator Move()
    {
        if(isMoving)
        {
            yield break;
        }

        isMoving = true;

        while(stepsToMove >0)
        {
            routePosition++;
            Vector3 nextPos = route.childNodeList[routePosition].transform.position;

            while(MoveToNextNode(nextPos))
            {
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);
            stepsToMove--;
            doneSteps++;
        }
        //Verificar a casa em que parou
        GameManager.instance.state = GameManager.States.SWITCH_PLAYER;
        isMoving = false;
    }

    bool MoveToNextNode(Vector3 nextPos)
    {
        return nextPos != (transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime));
    }

    public void MakeTurn(int diceNumber)
    {
        stepsToMove = diceNumber;
        if(doneSteps + stepsToMove < route.childNodeList.Count)
        {
            StartCoroutine(Move());
        }
        else
        {
            GameManager.instance.state = GameManager.States.SWITCH_PLAYER;
        }
    }
}
