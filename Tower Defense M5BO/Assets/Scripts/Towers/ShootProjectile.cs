using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{

    [SerializeField] internal GameObject projectile;
    private TowerStats towerStats;
    public TargetScript targetScript;
    private float firingDelay = 0;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        towerStats = GetComponentInChildren<TowerStats>();
        targetScript = GetComponentInChildren<TargetScript>();    
    }

    // Update is called once per frame
    void Update()
    {
        firingDelay -= Time.deltaTime;
        if (firingDelay <= 0 && targetScript.targetList.Count > 0)
        {
            firingDelay = 10/towerStats.firingSpeed;
            GameObject[] firstPriority = targetScript.targetList.OrderByDescending(t => t.GetComponent<EnemyStats>().progress).ToArray();
            target = firstPriority[0].transform;

            Vector3 dir = FindFiringDirection();
            Shoot(dir);
        }
    }

    private Vector3 FindFiringDirection()
    {
        Vector3 dir = target.position - transform.position;
        dir.Normalize();
        return dir;
    }
    private void Shoot(Vector3 dir)
    {
        GameObject firedProjectile = Instantiate(projectile, transform.position, Quaternion.identity);
        ProjectileStats projectileStats = firedProjectile.GetComponent<ProjectileStats>();
        ApplyProjectileStats(projectileStats, dir);
        

    }
    private void ApplyProjectileStats(ProjectileStats p, Vector3 dir)
    {
        p.damage = towerStats.projectileDamage;
        p.pierce = towerStats.projectilePierce;
        p.speed = towerStats.projectileSpeed;
        p.despawnTime = towerStats.projectileDespawnTime;
        p.direction = dir;
        p.target = target;
    }
}
