using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateEnemyNameText : MonoBehaviour
{
    internal void UpdateText(string text)
    {
        GetComponent<TMP_Text>().text = text;
    }
}
