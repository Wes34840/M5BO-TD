using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    internal int totalEnemies, totalSpawned;
    [SerializeField] private CurrentEnemies enemyHolder;
    internal EnemyDatabase enemyDatabase;
    [SerializeField] private Transform spawnPoint;
    void Start()
    {
        enemyDatabase = GetComponentInChildren<EnemyDatabase>();
        enemyHolder = GetComponentInChildren<CurrentEnemies>();
    }

    internal void InitWave(WaveStructure wave)
    {
        enemyHolder.ClearList();

        totalSpawned = 0;
        totalEnemies = 0;

        WavePart[] parts = new WavePart[wave.waveStructure.Count];

        for (int i = 0; i < wave.waveStructure.Count; i++)
        {
            parts[i] = wave.waveStructure[i];
            totalEnemies += parts[i].count;
        }
        StartCoroutine(SpawnWave(parts));
    }

    private IEnumerator SpawnWave(WavePart[] parts)
    {
        for (int i = 0; i < parts.Length; i++)
        {
            StartCoroutine(SpawnWavePart(parts[i]));
            yield return new WaitForSeconds(parts[i].delay / 10);
        }
    }

    private IEnumerator SpawnWavePart(WavePart part)
    {
        for (int i = 0; i < part.count; i++)
        {
            yield return new WaitForSeconds(part.spacing / 10);
            GameObject enemy = Instantiate(enemyDatabase.Enemies[(int)part.enemyID], spawnPoint.position, Quaternion.identity);
            enemyHolder.currentEnemies.Add(enemy);
            totalSpawned++;
        }
    }
    internal bool hasFinished()
    {
        return totalSpawned == totalEnemies;
    }
}
