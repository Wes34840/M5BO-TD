using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExitScript : MonoBehaviour
{

    List<GameObject> objects = new List<GameObject>();
    
    void Start()
    {
        
    }

    void Update()
    {
        if (objects.Count == 0)
        {
            return;
        }
        Vector2 dist = objects[0].transform.position - transform.position;
        if (dist.magnitude <= 0.01)
        {
            ExitEnemy(objects[0]);
        }
    }
    private void ExitEnemy(GameObject enemy)
    {
        objects.Remove(enemy);
        GlobalData.playerHealth -= enemy.GetComponent<EnemyStats>().health;
        Destroy(enemy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objects.Add(collision.gameObject);
    }

}
