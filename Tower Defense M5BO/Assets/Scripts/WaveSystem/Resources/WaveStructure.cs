using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WaveStructure
{
    public List<WavePart> waveStructure;
    public float endCash;

    public WaveStructure(List<WavePart> waveStructure, float endCash)
    {
        this.waveStructure = waveStructure;
        this.endCash = endCash;
    }
}
