using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{


    Transform[] childObjects;

    public List<Transform> childNodeList = new List<Transform>();

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        FillNodes();

        for(int i =0; i< childNodeList.Count;i++)
        {
            Vector3 currentPos = childNodeList[i].position; 
            if(i>0)
            {
                Vector3 prevPos = childNodeList[i - 1].position;
                Gizmos.DrawLine(prevPos, currentPos);
            }
        }
    }

    void FillNodes()
    {
        childNodeList.Clear();

        childObjects = GetComponentsInChildren<Transform>(); 

        int id = 0;
        foreach(Transform child in childObjects)
        {
            Node n = child.GetComponent<Node>();
            if(child != this.transform && n != null)
            {
                childNodeList.Add(child);
                n.SetNodeId(id++);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        FillNodes();
    }

}
