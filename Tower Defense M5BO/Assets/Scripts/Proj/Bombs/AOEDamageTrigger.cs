using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEDamageTrigger : MonoBehaviour
{
    [SerializeField] internal ProjectileStats stats;
    private AOEDoDamage aoeScript;
    private bool hasHit;
    void Start()
    {
        stats = GetComponent<ProjectileStats>();
        aoeScript = GetComponentInChildren<AOEDoDamage>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && !hasHit)
        {
            hasHit = true;
            Destroy(gameObject);
            aoeScript.DealDamage(stats);
            GetComponent<PlayExplosionEffect>().PlayEffect();
        }
    }
}
