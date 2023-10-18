using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateTowerSellPrice : MonoBehaviour
{
    internal void UpdateText(float value)
    {
        GetComponent<TMP_Text>().text = $"${value}";
    }
}
