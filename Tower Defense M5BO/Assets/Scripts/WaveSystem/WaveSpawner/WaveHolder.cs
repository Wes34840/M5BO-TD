using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHolder : MonoBehaviour
{
    public LoadWaveJSON JSONLoader;
    public List<WaveStructure> waves;

    [SerializeField] private WaveSpawner spawner;

    [SerializeField] private int waveIndex;
    [SerializeField] internal bool waveIsActive;
    private void Start()
    {
        JSONLoader = GetComponent<LoadWaveJSON>();
        waves = JSONLoader.LoadWave();
    }

    // Update is called once per frame
    void Update()
    { 

    }

    public void StartWave(WaveStructure wave)
    {
        spawner.InitWave(wave);
    }
}
