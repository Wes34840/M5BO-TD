using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    internal float damage, pierce, speed, despawnTime, hasPierced;
    internal Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, despawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (hasPierced >= pierce)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && hasPierced < pierce)
        {
            hasPierced++;
            collision.GetComponent<EnemyStats>().health -= damage;
        }
    }
}
