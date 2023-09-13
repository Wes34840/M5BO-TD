using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnSpawn : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject);
    }

}
