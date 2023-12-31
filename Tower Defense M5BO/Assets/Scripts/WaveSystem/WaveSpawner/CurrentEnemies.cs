using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CurrentEnemies : MonoBehaviour
{
    [SerializeField] internal WaveSpawner spawner;
    [SerializeField] internal List<GameObject> currentEnemies;

    private void Start()
    {
        spawner = GetComponentInParent<WaveSpawner>();
    }

    internal void RemoveEnemyFromList(GameObject enemy)
    {
        currentEnemies.Remove(enemy);
        CheckIfFinished();
    }
    internal void CheckIfFinished()
    {
        Debug.Log(spawner.hasFinished());
        if (currentEnemies.Count == 0 && spawner.hasFinished())
        {
            GetComponentInParent<WaveHolder>().FinishWave();
        }
    }

    internal void ClearList()
    {
        currentEnemies.Clear();
    }

}
