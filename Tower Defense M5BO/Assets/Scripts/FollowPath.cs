using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    private Nodes pathScript;
    private int nodeIndex;
    public float moveSpeed = 1f;
    void Start()
    {
        
        pathScript = GameObject.Find("Path").GetComponent<Nodes>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = pathScript.pathNodes[nodeIndex].position - transform.position;
        if (delta.magnitude <= 0.001)
        {
            nodeIndex++;
            return;
        }
        delta.Normalize();
        transform.position += delta * Time.deltaTime;
    }
}