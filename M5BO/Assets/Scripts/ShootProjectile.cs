using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ShootProjectile : MonoBehaviour
{

    [SerializeField] GameObject projectile;
    private TowerStats towerStats;
    public TargetScript targetScript;
    private float firingDelay;
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
            firingDelay = towerStats.firingSpeed;

            target = targetScript.targetList[0].transform;

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
        ProjectileScript projectileScript = firedProjectile.GetComponent<ProjectileScript>();
        projectileScript.direction = dir;
        firedProjectile.transform.right = target.position - transform.position;
        ApplyProjectileStats(projectileScript);

    }
    private void ApplyProjectileStats(ProjectileScript p)
    {
        p.damage = towerStats.projectileDamage;
        p.pierce = towerStats.projectilePierce;
        p.speed = towerStats.projectileSpeed;
        p.despawnTime = towerStats.projectileDespawnTime;
    }
}
