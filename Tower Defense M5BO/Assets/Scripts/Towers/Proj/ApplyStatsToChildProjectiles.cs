using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ApplyStatsToChildProjectiles : MonoBehaviour
{
    ProjectileStats stats;
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<ProjectileStats>();
        for (int i = 0; i < transform.childCount; i++)
        {
            ProjectileStats projectile = transform.GetChild(i).GetComponent<ProjectileStats>();
            ApplyProjectileStats(projectile);

            Quaternion myRotation = Quaternion.AngleAxis(-10 + 10*i, transform.forward);
            Vector3 result = myRotation * stats.direction;

            projectile.direction = result;

        }
    }
    private void ApplyProjectileStats(ProjectileStats p)
    {
        p.damage = stats.damage;
        p.pierce = stats.pierce;
        p.speed = stats.speed;
        p.despawnTime = stats.despawnTime;
    }
}
