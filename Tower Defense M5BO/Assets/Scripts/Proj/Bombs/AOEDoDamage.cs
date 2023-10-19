using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEDoDamage : MonoBehaviour
{
    List<GameObject> targets = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            targets.Add(collision.gameObject);
        }
    }
    internal void DealDamage(ProjectileStats stats)
    {
        for (int i = 0; i < targets.Count; i++)
        {
            if (stats.hasPierced < stats.pierce)
            {
                stats.hasPierced++;
                if (targets[i] != null) targets[i].GetComponent<EnemyStats>().health -= stats.damage;
                GlobalData.playerCash += stats.damage;
            }
        }
        if (GetComponent<SpawnClusterBombs>() != null)
        {
            GetComponent<SpawnClusterBombs>().SpawnCluster();
        }
    }
}
