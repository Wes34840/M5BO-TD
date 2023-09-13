using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerStats : MonoBehaviour
{ 
    // Tower
    [SerializeField] internal float firingSpeed;

    // Projectile
    [SerializeField] internal float projectileDamage;
    [SerializeField] internal float projectilePierce;
    [SerializeField] internal float projectileSpeed;
    [SerializeField] internal float projectileDespawnTime;
}
