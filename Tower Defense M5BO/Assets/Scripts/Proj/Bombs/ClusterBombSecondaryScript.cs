using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterBombSecondaryScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Explode());
    }

    private IEnumerator Explode()
    {
        yield return new WaitForSeconds(0.2f);
        GetComponentInChildren<AOEDoDamage>().DealDamage(GetComponent<ProjectileStats>());
        GetComponent<PlayExplosionEffect>().PlayEffect();
        Destroy(gameObject);
    }
}
