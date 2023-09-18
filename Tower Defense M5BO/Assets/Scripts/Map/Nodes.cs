using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{

    public Transform[] pathNodes;

    void Start()
    {
        pathNodes = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            pathNodes[i] = transform.GetChild(i);
        }
    }

}
