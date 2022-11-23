using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathScript : MonoBehaviour
{

    public Route currentRoute; 

    public int routePosition;
    public int steps;
    public bool moveAllowed = false;
    bool isMoving;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {

            steps = Random.Range(1, 7);
            Debug.Log("Numero de passos: " + steps);
            if(routePosition + steps < currentRoute.childNodeList.Count)
            {
                StartCoroutine(Move());
            }
            else
            {
                Debug.Log("Caminho maximo atingido");
            }

        }
    }

    IEnumerator Move()
    {
        if (isMoving)
        {
            yield break; 
        }
        isMoving = true;

        while(steps>0)
        {
            Vector3 nextPos = currentRoute.childNodeList[routePosition + 1].position;
            while (MoveToNextNode(nextPos)) { yield return null; }

            yield return new WaitForSeconds(0.1f);
            steps--;
            routePosition++;
        }

        isMoving = false; 

        bool MoveToNextNode(Vector3 goal)
        {
            return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
            
        }
    }


}
