using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateCashCounter : MonoBehaviour
{
    TMP_Text textField;
    void Start()
    {
        textField = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textField.text = $"${GlobalData.playerCash}";
    }
}
