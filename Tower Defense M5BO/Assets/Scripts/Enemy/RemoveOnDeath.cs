using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOnDeath : MonoBehaviour
{
    EnemyStats stats;
    bool isDead;
    void Start()
    {
        stats = GetComponent<EnemyStats>();
    }

    void Update()
    {
        if (stats.health <= 0 && !isDead)
        {
            isDead = true;
            RemoveEnemy();
        }
    }

    internal void RemoveEnemy()
    {
        GameObject.Find("EnemyHandler").GetComponent<CurrentEnemies>().RemoveEnemyFromList(gameObject);
        GlobalData.playerCash += stats.health; // prevent player from getting too much money from an attack,
                                               // for example: if an enemy has 3 health and takes 4 damage,
                                               // player is granted 4 cash but this takes away the excess cash
                                               // (or at least, it should)
        Destroy(gameObject);
        GetComponentInChildren<ShowEnemyHealth>().ClosePopup();
    }
}
