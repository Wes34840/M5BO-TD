using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEndLifespan : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, GetComponent<ProjectileStats>().despawnTime);
    }

}
