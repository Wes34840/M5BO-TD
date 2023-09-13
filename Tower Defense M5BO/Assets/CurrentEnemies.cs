using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CurrentEnemies : MonoBehaviour
{
    [SerializeField] internal WaveSpawner spawner;
    [SerializeField] internal GameObject[] currentEnemies;

    private void Update()
    {
        if (currentEnemies.All(e=> e.GetComponent<EnemyStats>().health < 0) && spawner.finishedSpawning)
        {
            GetComponentInParent<WaveHolder>().waveIsActive = false;
        }
    }
}
