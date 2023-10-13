using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDoDamage : MonoBehaviour
{
    [SerializeField] internal ProjectileStats stats;
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<ProjectileStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stats.hasPierced >= stats.pierce)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && stats.hasPierced < stats.pierce)
        {
            stats.hasPierced++;
            collision.GetComponent<EnemyStats>().health -= stats.damage;
            GlobalData.playerCash += stats.damage; // see RemoveOnDeath.cs for how this isn't exploitable as fuck
        }
    }
}
