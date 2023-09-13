using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHolder : MonoBehaviour
{
    public LoadWaveJSON JSONLoader;
    public List<WaveStructure> waves;
    private void Start()
    {
        JSONLoader = GetComponent<LoadWaveJSON>();
        waves = JSONLoader.LoadWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
