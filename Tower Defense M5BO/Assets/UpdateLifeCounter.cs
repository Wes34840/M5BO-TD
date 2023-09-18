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
        textField.text = $"Wave: {GlobalData.playerHealth}";
    }
}
