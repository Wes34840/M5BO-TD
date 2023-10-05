using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{

    public Transform[] pathNodes;

    void Start()
    {
        InitPathNodes();
    }
    private void InitPathNodes()
    {
        Transform nodeHolder = transform.GetChild(0);
        pathNodes = new Transform[nodeHolder.childCount];

        for (int i = 0; i < nodeHolder.childCount; i++)
        {
            pathNodes[i] = nodeHolder.GetChild(i);
        }
    }
}
