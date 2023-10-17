using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    [SerializeField] internal ProjectileStats stats;
    internal Transform target;
    internal Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<ProjectileStats>();
        Destroy(gameObject, stats.despawnTime);

        Vector3 velocity = stats.direction * stats.speed;
        float Angle = Mathf.Atan2(velocity.y, velocity.x);
        transform.localEulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * Angle);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += stats.direction * stats.speed * Time.deltaTime;
    }

    
}
