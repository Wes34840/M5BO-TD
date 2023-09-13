using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WavePart
{
    public EnemyID enemyID;
    public int count;
    public float spacing;
    public float delay;
    
    internal WavePart(EnemyID enemyID, int count, float spacing, float delay)
    {
        this.enemyID = enemyID;
        this.count = count;
        this.spacing = spacing;
        this.delay = delay;
    }
}
