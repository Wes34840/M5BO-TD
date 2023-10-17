using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEndLifespan : MonoBehaviour
{
    [SerializeField] private float despawnTime;
    void Start()
    {
        if (GetComponent<ProjectileStats>() != null) despawnTime = GetComponent<ProjectileStats>().despawnTime;
        Destroy(gameObject, despawnTime);
    }

}
