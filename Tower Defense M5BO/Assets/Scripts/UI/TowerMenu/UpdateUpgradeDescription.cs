using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateUpgradeDescription : MonoBehaviour
{
    void Start()
    {
        
    }

    internal void UpdateDescription(GameObject tower, int index)
    {
        GetComponent<TMP_Text>().text = tower.GetComponentInChildren<UpgradePathHolder>().paths[index].GetDescription();
    }
}
