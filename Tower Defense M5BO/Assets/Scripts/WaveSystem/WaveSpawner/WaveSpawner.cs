using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    internal float timeSinceStart;
    internal bool finishedSpawning = false;
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
        finishedSpawning = false;

        WavePart[] parts = new WavePart[wave.waveStructure.Count];

        for (int i = 0; i < wave.waveStructure.Count; i++)
        {
            parts[i] = wave.waveStructure[i];
        }
        StartCoroutine(SpawnWave(parts));
    }

    private IEnumerator SpawnWave(WavePart[] parts)
    {
        StartCoroutine(FinishSpawning(parts));
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
            timeSinceStart += part.spacing/10;
            GameObject enemy = Instantiate(enemyDatabase.Enemies[(int)part.enemyID], spawnPoint.position, Quaternion.identity);
            enemyHolder.currentEnemies.Add(enemy);
        }
    }
    private IEnumerator FinishSpawning(WavePart[] parts)
    {
        float delayUntilFinish = 0;
        for (int i = 0; i < parts.Length; i++)
        {
            delayUntilFinish += (parts[i].spacing / 10) * parts[i].count;
            if (parts[i].delay != 0) delayUntilFinish -= (parts[i].spacing / 10 * parts[i].count) - (parts[i].delay / 10);
        }
        yield return new WaitForSeconds(delayUntilFinish+0.5f);
        finishedSpawning = true;
        enemyHolder.CheckIfFinished();
        timeSinceStart = 0;
    }
}
