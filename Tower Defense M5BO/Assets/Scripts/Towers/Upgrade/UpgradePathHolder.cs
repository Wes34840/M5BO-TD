using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePathHolder : MonoBehaviour
{
    [SerializeField] internal TowerUpgrader[] paths;

    internal void ApplyUpgradeFromPath(int pathIndex)
    {
        paths[pathIndex].InitUpgrade();
    }
}
