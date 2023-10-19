using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHolder : MonoBehaviour
{
    public LoadWaveJSON JSONLoader;
    public List<WaveStructure> waves;

    [SerializeField] EndScreen endScreen;

    [SerializeField] private WaveSpawner spawner;
    private ToggleFFButton toggleFF;
    [SerializeField] internal int waveIndex;
    [SerializeField] internal bool waveIsActive;
    private void Start()
    {
        spawner = GetComponent<WaveSpawner>();
        JSONLoader = GetComponent<LoadWaveJSON>();
        waves = JSONLoader.LoadWave();
        toggleFF = GetComponent<ToggleFFButton>();
    }

    internal void StartWave()
    {
        waveIndex++;
        waveIsActive = true;
        WaveStructure wave = waves[waveIndex];
        toggleFF.ToggleOn();
        spawner.InitWave(wave);
    }

    internal void FinishWave()
    {
        waveIsActive = false;
        toggleFF.ToggleOff();
        GlobalData.playerCash += waves[waveIndex].endCash;
        if (waveIndex == waves.Count-1 && GlobalData.gameIsActive)
        {
            WinGame();
        }

    }
    private void WinGame()
    {
        endScreen.Victory();
    }
}
