using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    WavePart[] allParts;
    internal bool finishedSpawning = false;
    [SerializeField] private CurrentEnemies enemyHolder;
    internal EnemyDatabase enemyDatabase;
    [SerializeField] private Transform spawnPoint;
    void Start()
    {
        enemyDatabase = transform.parent.GetComponentInChildren<EnemyDatabase>();
    }

    internal void InitWave(WaveStructure wave)
    {
        finishedSpawning = false;
        allParts = new WavePart[wave.waveStructure.Count];

        for (int i = 0; i < wave.waveStructure.Count; i++)
        {
            allParts[i] = wave.waveStructure[i];
        }

        for (int i = 0; i < allParts.Length; i++)
        {
            SpawnWavePart(allParts[i]);
            StartCoroutine(WaitForDelay(allParts[i].delay));
        }
        finishedSpawning = true;
    }
    internal void SpawnWavePart(WavePart part)
    {
        for (int i = 0; i < part.count; i++)
        {
            Instantiate(enemyDatabase.Enemies[(int)part.enemyID], spawnPoint.position, Quaternion.identity);
            StartCoroutine(WaitForDelay(part.spacing / 10));
        }
    }
    internal IEnumerator WaitForDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
    }
}
