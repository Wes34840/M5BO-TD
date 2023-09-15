using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WavePart
{
    public EnemyID enemyID;     // enemy in this part
    public int count;           // amount of enemies in this part
    public float spacing;       // space between enemies
    public float delay;         // delay between spawning parts
    
    internal WavePart(EnemyID enemyID, int count, float spacing, float delay)
    {
        this.enemyID = enemyID;
        this.count = count;
        this.spacing = spacing;
        this.delay = delay;
    }
}
