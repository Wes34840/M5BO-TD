using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class Upgrade
{
    [SerializeField] internal string title;
    [SerializeField] internal string description;
    [SerializeField] internal float cost;
    [SerializeField] internal Sprite sprite;
    [SerializeField] internal float[] stats;
    [SerializeField] internal GameObject projectile;
    public Upgrade (float cost, Sprite sprite, float[] stats, GameObject projectile)
    {
        this.cost = cost;
        this.sprite = sprite;
        this.stats = stats;
        this.projectile = projectile;
    }
}
