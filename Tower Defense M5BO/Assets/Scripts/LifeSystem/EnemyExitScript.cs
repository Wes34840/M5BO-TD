using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExitScript : MonoBehaviour
{
    private bool playerIsDead;
    public List<GameObject> objects = new List<GameObject>();
    [SerializeField] private EndScreen killPlayer;
    void Update()
    {
        if (objects.Count == 0)
        {
            return;
        }
        Vector2 dist = objects[0].transform.position - transform.position;
        if (dist.magnitude <= 0.1)
        {
            ExitEnemy(objects[0]);
        }
    }
    private void ExitEnemy(GameObject enemy)
    {
        objects.Remove(enemy);
        GlobalData.playerHealth -= enemy.GetComponent<EnemyStats>().health;
        enemy.GetComponent<RemoveOnDeath>().RemoveEnemy();
        if (CheckIfDead() && !playerIsDead && GlobalData.gameIsActive) KillPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) objects.Add(collision.gameObject);
    }

    private bool CheckIfDead()
    {
        if (GlobalData.playerHealth <= 0) return true;
        return false;
    }

    private void KillPlayer()
    { 
        playerIsDead = true;
        GlobalData.gameIsActive = false;
        killPlayer.Defeat();
    }

}
