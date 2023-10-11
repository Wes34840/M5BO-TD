using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateLifeCounter : MonoBehaviour
{
    TMP_Text textField;
    void Start()
    {
        textField = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (GlobalData.playerHealth <= 0)
        {
            textField.text = "Lives: 0";
            return;
        }
        textField.text = $"Lives: {GlobalData.playerHealth}";
    }
}
