using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] internal string enemyName;
    [SerializeField] internal float moveSpeed;
    [SerializeField] internal float maxHealth;
    [SerializeField] internal float health;
    [SerializeField] internal float progress;
}
