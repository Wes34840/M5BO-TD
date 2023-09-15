using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOnDeath : MonoBehaviour
{
    EnemyStats stats;
    void Start()
    {
        stats = GetComponent<EnemyStats>();
    }

    void Update()
    {
        if (stats.health <= 0)
        {
            GameObject.Find("EnemyHandler").GetComponent<CurrentEnemies>().RemoveEnemyFromList(gameObject);
            Destroy(gameObject);
        }
    }
}
