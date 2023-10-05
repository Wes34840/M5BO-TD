using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateUpgradeTitle : MonoBehaviour
{
    void Start()
    {
        
    }

    internal void UpdateTitle(GameObject tower, int index)
    {
        GetComponent<TMP_Text>().text = tower.GetComponentInChildren<UpgradePathHolder>().paths[index].GetTitle();
    }
}
