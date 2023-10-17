using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class SpawnClusterBombs : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    internal void SpawnCluster()
    {
        GameObject bombHolder = Instantiate(prefab, transform.position, Quaternion.identity);
        ProjectileStats newStats = gameObject.GetComponentInParent<ProjectileStats>();
        ApplyStats(bombHolder.GetComponent<ProjectileStats>(), newStats);
    }

    internal void ApplyStats(ProjectileStats hold, ProjectileStats parent)
    {
        hold.damage = parent.damage;
        hold.pierce = parent.pierce;
        hold.speed = parent.speed/2;
        hold.despawnTime = 1f;
        hold.direction = parent.direction;
    }
    
}

