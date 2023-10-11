using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    private Nodes pathScript;
    private int nodeIndex;
    private EnemyStats stats;
    UpdateLookDirection lookDir;
    void Start()
    {
        stats = GetComponent<EnemyStats>();
        pathScript = GameObject.Find("Path").GetComponent<Nodes>();
        lookDir = GetComponent<UpdateLookDirection>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = pathScript.pathNodes[nodeIndex].position - transform.position;
        if (delta.magnitude <= 0.02f && nodeIndex != pathScript.pathNodes.Length-1)
        {
            nodeIndex++;
            lookDir.UpdateDirection(pathScript.pathNodes[nodeIndex].position);
            return;
        }
        delta.Normalize();
        transform.position += delta * (stats.moveSpeed/10) * Time.deltaTime;
        stats.progress += Time.deltaTime;
    }
}
