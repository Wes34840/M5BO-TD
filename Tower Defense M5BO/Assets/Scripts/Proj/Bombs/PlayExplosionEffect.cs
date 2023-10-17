using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayExplosionEffect : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    internal void PlayEffect()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
