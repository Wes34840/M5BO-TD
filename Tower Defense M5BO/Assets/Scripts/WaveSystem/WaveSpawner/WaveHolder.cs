using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHolder : MonoBehaviour
{
    public LoadWaveJSON JSONLoader;
    public List<WaveStructure> waves;

    [SerializeField] private WaveSpawner spawner;

    [SerializeField] internal int waveIndex;
    [SerializeField] internal bool waveIsActive;
    private void Start()
    {
        spawner = GetComponent<WaveSpawner>();
        JSONLoader = GetComponent<LoadWaveJSON>();
        waves = JSONLoader.LoadWave();
    }

    internal void StartWave()
    {
        waveIndex++;
        waveIsActive = true;
        WaveStructure wave = waves[waveIndex];
        spawner.InitWave(wave);
    }

    internal void FinishWave()
    {
        waveIsActive = false;
        GlobalData.playerCash += waves[waveIndex].endCash;
    }
}
