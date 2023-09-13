using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WaveStructure
{
    public List<WavePart> waveStructure;

    public WaveStructure(List<WavePart> waveStructure)
    {
        this.waveStructure = waveStructure;
    }
}
